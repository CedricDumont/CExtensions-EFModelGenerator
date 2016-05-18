using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Generator        
    {
        public Generator(GenerationOptions generatorOptions)
        {
            Provider = createInstance<IProvider>(generatorOptions.ProviderType, generatorOptions.ProviderTypeArguments);

            Serializer = createInstance<ISerializer>(generatorOptions.SerializerType, generatorOptions.SerializerTypeArguments);

            GeneratorOptions = generatorOptions;
        }


        public Generator(IProvider provider, ISerializer serializer, GenerationOptions generatorOptions = null)
        {
            Provider = provider;
            Serializer = serializer;
            GeneratorOptions = generatorOptions ?? new GenerationOptions();
        }

        private T createInstance<T>(string typename, object[] arguments) where T : class
        {
            Type instanceType = Type.GetType(typename);

            T result = Activator.CreateInstance(instanceType, arguments) as T;

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
            catch(Exception ex)
            {
                writer.Write(ex.Message);
                throw ex;
            }

        }
    }
}
