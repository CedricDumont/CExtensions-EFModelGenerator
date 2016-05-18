using CExtensions.EFModelGenerator.Core;
using System;
using System.IO;
using CExtensions.EFModelGenerator.Common;
using System.Text.RegularExpressions;

namespace CExtensions_EFModelGenerator.Command
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string theDirectory = Directory.GetParent(Path.GetDirectoryName(Directory.GetParent(path).FullName)).FullName;

            string providerType = "CExtensions.EFModelGenerator.SqlServer.SqlDataProvider, CExtensions.EFModelGenerator.SqlServer";
            Object[] providerArguments = new Object[] { @"Server=MC0QKBSC\SQLEXPRESS;Database=FSEND_NET;Trusted_Connection=True;", "dbo" };

            string modelSerializerType = "CExtensions.EFModelGenerator.Serializers.ModelSerializer, CExtensions.EFModelGenerator.Serializers";
            Object[] SerializerModelArguments = new Object[] { @"my.business.space" };

            string dbContextSerializerType = "CExtensions.EFModelGenerator.Serializers.DBContextSerializer, CExtensions.EFModelGenerator.Serializers";
            Object[] SerializerDbContextArguments = new Object[] { @"my.business.space", "MyContext" };

            String schema = "dbo";


            GenerationOptions options = new GenerationOptions();
            options.IgnoreTableRegex.Add(new Regex("^backup", RegexOptions.IgnoreCase));
            options.ProviderType = providerType;
            options.ProviderTypeArguments = providerArguments;
            options.SchemaName = schema;
            //options.ColumnConfiguration.AddFormatter(new IDColumnFormatter());
            //options.ColumnConfiguration.AddFormatter(new KeepIdColumnNameFormatter());
            //options.ColumnConfiguration.AddFormatter(new RemoveUnderscoreNameFormatter());

            using (var tw = File.CreateText($"{theDirectory}\\Model.cs"))
            {
                options.SerializerType = modelSerializerType;
                options.SerializerTypeArguments = SerializerModelArguments;
                Generator generator = new Generator(options);
                generator.Generate(tw);
            }

            using (var tw = File.CreateText($"{theDirectory}\\MyContext.cs"))
            {
                options.SerializerType = dbContextSerializerType;
                options.SerializerTypeArguments = SerializerDbContextArguments;
                Generator generator = new Generator(options);
                generator.Generate(tw);
            }

        }
    }
}
