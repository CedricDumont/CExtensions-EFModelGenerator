using CExtensions.EFModelGenerator.Common;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CExtensions.EFModelGenerator.Core
{
    public class Generator
    {
        public Generator(GenerationOptions generatorOptions)
        {
            GeneratorOptions = generatorOptions;

            Provider = createInstance<IProvider>(generatorOptions.ProviderType, generatorOptions.ProviderTypeArguments);

            Serializer = createInstance<ISerializer>(generatorOptions.SerializerType, generatorOptions.SerializerTypeArguments);

            
        }


        public Generator(IProvider provider, ISerializer serializer, GenerationOptions generatorOptions = null)
        {
            Provider = provider;
            Serializer = serializer;
            GeneratorOptions = generatorOptions ?? new GenerationOptions();
        }

        private T createInstance<T>(string typename, object[] arguments) where T : class
        {
            if (GeneratorOptions.ImplementingClassPath != null)
            {
                //add a resolver to load the assemblies implementing the customization
                var customizationDlls = new DirectoryInfo(GeneratorOptions.ImplementingClassPath).GetFiles("*.dll");

                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    var name = args.Name.Split(',');

                    var dll = customizationDlls.FirstOrDefault(fi => fi.Name == name[0] + ".dll");
                    if (dll == null)
                    {
                        return null;
                    }

                    Assembly assem = Assembly.LoadFile(dll.FullName);

                    return assem;
                };
            }

            Type instanceType = Type.GetType(typename);

            if (instanceType == null)
            {
                throw new ArgumentException("Did you forget to reference assembly to create : " + typeof(T));
            }

            var objectinstance = Activator.CreateInstance(instanceType, arguments);

            T result = objectinstance as T;

            if (result == null)
            {
                throw new ArgumentException("Should implement must implement : " + typeof(T));
            }

            return result;
        }

        public GenerationOptions GeneratorOptions { get; private set; }

        public IProvider Provider { get; private set; }

        public ISerializer Serializer { get; private set; }

        public void Generate(TextWriter writer)
        {
            try
            {
                ModelInitializer initializer = new ModelInitializer(Provider, GeneratorOptions);

                Schema schema = initializer.Initialize(GeneratorOptions.SchemaName);

                String serializedModel = Serializer.Serialize(schema);

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
