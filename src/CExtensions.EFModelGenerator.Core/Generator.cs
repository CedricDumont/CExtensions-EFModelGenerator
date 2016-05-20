using CExtensions.EFModelGenerator.Common;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace CExtensions.EFModelGenerator.Core
{
    public class Generator
    {
        public Generator(GenerationOptions generatorOptions)
        {
            GeneratorOptions = generatorOptions;

            Provider = createInstance(generatorOptions.ProviderType, generatorOptions.ProviderTypeArguments);

            Serializer = createInstance(generatorOptions.SerializerType, generatorOptions.SerializerTypeArguments);
        }

        public Generator(IProvider provider, ISerializer serializer, GenerationOptions generatorOptions = null)
        {
            Provider = provider;
            Serializer = serializer;
            GeneratorOptions = generatorOptions ?? new GenerationOptions();
        }

        private Object createInstance(string typename, object[] arguments)
        {
            if (GeneratorOptions.ImplementingClassPath != null)
            {
                //add a resolver to load the assemblies implementing the customization
                var customizationDlls = new DirectoryInfo(GeneratorOptions.ImplementingClassPath).GetFiles("*.dll");

                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    Debug.WriteLine("received name to load " + args.Name);
                    var name = args.Name.Split(',');

                    var dll = customizationDlls.FirstOrDefault(fi => fi.Name == name[0] + ".dll");
                    if (dll == null)
                    {
                        return null;
                    }

                    Debug.WriteLine("loading " + dll.FullName);

                    Assembly assem = Assembly.LoadFile(dll.FullName);

                    return assem;
                };
            }

            Type instanceType = Type.GetType(typename);

            if (instanceType == null)
            {
                throw new ArgumentException("Did you forget to reference assembly to create : " + typename);
            }

            Evidence currEvidence = AppDomain.CurrentDomain.Evidence;

            //var temporary = AppDomain.CurrentDomain.CreateInstanceAndUnwrap(instanceType.Assembly.FullName, 
            //    instanceType.FullName, true, BindingFlags.CreateInstance,
            //    null, arguments, null, new object[] { });

            var objectinstance = Activator.CreateInstance(instanceType, arguments);

            return objectinstance;

            //T result = temporary as T;

            //if (result == null)
            //{
            //    throw new ArgumentException("Should implement must implement : " + typeof(T));
            //}

            //return result;
        }

        public GenerationOptions GeneratorOptions { get; private set; }

        public Object Provider { get; private set; }

        public Object Serializer { get; private set; }

        public void Generate(TextWriter writer)
        {
            try
            {
                ModelInitializer initializer = new ModelInitializer(Provider, GeneratorOptions);

                Schema schema = initializer.Initialize(GeneratorOptions.SchemaName);

                string serializedSchema = JsonConvert.SerializeObject(
                                                        schema,
                                                        Formatting.None
                                                        );

                //String serializedModel =  Serializer.Serialize(schema);
                String serializedModel = (string)Utils.CallMethodOnObject(Serializer, "CallSerializeWith", new object[] { serializedSchema });

                writer.Write(serializedModel);
            }
            catch (Exception ex)
            {
                writer.Write(ex.Message);
                throw ex;
            }

        }
    }
}
