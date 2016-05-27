using CExtensions.EFModelGenerator.Model;
using CExtensions.EFModelGenerator.Providers;
using CExtensions.EFModelGenerator.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace CExtensions.EFModelGenerator
{
    public class Generator
    {
        public ApplicationInfo _licenceInfo = new ApplicationInfo();

        private Generator(GenerationOptions generatorOptions)
        {
            GeneratorOptions = generatorOptions;

            //Initialize the provider
            if (generatorOptions.ProviderType == null)
            {
                //default to sqlserver provider
                generatorOptions.ProviderType = "CExtensions.EFModelGenerator.Providers.SqlDataProvider, CExtensions.EFModelGenerator";
                generatorOptions.ProviderTypeArguments = new Object[] { generatorOptions.ConnectionString, generatorOptions.SchemaName };
            }

            Provider = createInstance(generatorOptions.ProviderType, generatorOptions.ProviderTypeArguments);

            //initialize the serializer
            if (generatorOptions.SerializerType == null)
            {
                generatorOptions.SerializerType = "CExtensions.EFModelGenerator.Serializers.CoreSerializer, CExtensions.EFModelGenerator";
                generatorOptions.SerializerTypeArguments = new Object[] { generatorOptions.ElementToGenerate, generatorOptions.Namespace, generatorOptions.ContextName };
            }

            Serializer = createInstance(generatorOptions.SerializerType, generatorOptions.SerializerTypeArguments);
        }

        public static void Generate(String configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                throw new Exception($"The file passed as parameter does not exist : {configFilePath}");
            }

            string fileContent = File.ReadAllText(configFilePath);

            EFMGSettings[] settingCollection = EFMGSettings.Build(fileContent);

            foreach (var setting in settingCollection)
            {
                ManageFilePath(configFilePath, setting);

                Generate(setting);
            }
        }

        private static void EnsureDirectoryFor(string path)
        {
            if (path == null) return;
            if (Path.GetDirectoryName(path) == null || Path.GetDirectoryName(path) == string.Empty) return;

            Directory.CreateDirectory(Path.GetDirectoryName(path));
        }



        public static string Generate(EFMGSettings settings, TextWriter sw = null)
        {
            Debug.WriteLine($"Generating file : {settings.FilePath}");

            var newFileName = settings.FilePath;

            if (File.Exists(newFileName))
            {
                File.Delete(newFileName);
            }

            EnsureDirectoryFor(newFileName);

            var tw = sw ?? File.CreateText(newFileName);
            //generate the code
            try
            {
                Generator generator = new Generator(settings.Options);
                generator.Generate(tw);
            }
            finally
            {
                if (sw == null)
                {
                    tw.Flush();
                    tw.Close();
                    tw.Dispose();
                }
            }


            return newFileName;

        }

        public static void ManageFilePath(string configFilePath, EFMGSettings settings)
        {
            if (settings.FilePath == null)
            {
                string newFileName = configFilePath;

                if (configFilePath.EndsWith(".json"))
                {
                    newFileName = configFilePath.Replace(".json", "");
                }

                newFileName = newFileName.EndsWith(".cs") ? newFileName : newFileName + ".cs";

                settings.FilePath = newFileName;

            }

            FileInfo info = new FileInfo(settings.FilePath);

            if (!Path.IsPathRooted(settings.FilePath))
            {
                var directoryName = Path.GetDirectoryName(configFilePath);
                var newFileName = Path.Combine(directoryName, settings.FilePath);
                settings.FilePath = newFileName;
            }
        }

        private void WriteGenerationInfoAndLicence(TextWriter writer)
        {
            writer.WriteLine(_licenceInfo.GenerationInfo);
        }

        private void Generate(TextWriter writer)
        {
            try
            {
                ModelInitializer initializer = new ModelInitializer(Provider, GeneratorOptions);

                Schema schema = initializer.Initialize(GeneratorOptions.SchemaName);

                string serializedSchema = JsonConvert.SerializeObject(
                                                        schema,
                                                        Formatting.None
                                                        );

                String serializedModel = (string)Utils.CallMethodOnObject(Serializer, "CallSerializeWith", new object[] { serializedSchema });

                WriteGenerationInfoAndLicence(writer);
                writer.Write("");
                writer.Write(serializedModel);
            }
            catch (Exception ex)
            {
                writer.WriteLine("-----------------------------------------------------------------");
                writer.WriteLine("!!!! An exception occured while generating the code. !!!!");
                writer.WriteLine($"Go to  https://github.com/CedricDumont/CExtensions-EFModelGenerator to check for known issues");
                writer.WriteLine("");
                writer.WriteLine("Or open an issue with the following Information : ");
                writer.WriteLine($"Exception Message : {ex.Message}");
                writer.WriteLine($"Exception Stack : {ex.StackTrace}");

                if(ex.InnerException != null)
                {
                    writer.WriteLine("");
                    writer.WriteLine($"Inner Exception Message : {ex.Message}");
                    writer.WriteLine($"Inner Exception Stack : {ex.StackTrace}");
                    writer.WriteLine("-----------------------------------------------------------------");
                }

                writer.WriteLine($"Options: {Environment.NewLine}{JsonConvert.SerializeObject(GeneratorOptions)}");
            }
        }

        private Object createInstance(string typename, object[] arguments)
        {
            if (GeneratorOptions.ImplementingClassPath != null)
            {
                //add a resolver to load the assemblies implementing the customization
                var externalPathDLLs = new DirectoryInfo(GeneratorOptions.ImplementingClassPath).GetFiles("*.dll");


                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    try
                    {
                        Debug.WriteLine("received name to load " + args.Name);
                        var name = args.Name.Split(',');

                        var dll = externalPathDLLs.FirstOrDefault(fi => fi.Name == name[0] + ".dll");
                        if (dll == null)
                        {
                            return null;
                        }

                        Debug.WriteLine("loading " + dll.FullName);

                        //_LoadedDlls.Add(dll);

                        Assembly assem = Assembly.LoadFile(dll.FullName);

                        return assem;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    return null;
                };
            }

            Type instanceType = Type.GetType(typename);

            if (instanceType == null)
            {
                throw new ArgumentException("Did you forget to reference assembly to create : " + typename);
            }

            //var temporary = AppDomain.CurrentDomain.CreateInstanceAndUnwrap(instanceType.Assembly.FullName, 
            //    instanceType.FullName, true, BindingFlags.CreateInstance,
            //    null, arguments, null, new object[] { });

            var objectinstance = Activator.CreateInstance(instanceType, arguments);

            return objectinstance;

        }

        public GenerationOptions GeneratorOptions { get; private set; }

        public Object Provider { get; private set; }

        public Object Serializer { get; private set; }


    }
}
