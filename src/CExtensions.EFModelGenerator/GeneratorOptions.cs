using CExtensions.EFModelGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public enum ElementToGenerateEnum
    {
        Model,
        DbContext,
        All
    }

    public class GenerationOptions
    {
        public GenerationOptions()
        {
            //  ColumnConfiguration = new ColumnConfiguration();
            IgnoreTableRegex = new string[0];
           // ColumnNameFormatters = new TypeConstructorSignature[0];
            //TableNameFormatters = new string[0];
            //DbSetNameFormatters = new string[0];
            ElementToGenerate = "Model";
            ContextName = "MyDbContext";
        }
        public String ConnectionString { get; set; }

        public string SchemaName { get; set; }

        public string Namespace { get; set; }

        public string ImplementingClassPath { get; set; }

        public string[] IgnoreTableRegex { get; set; }

        public String ProviderType { get; set; }

        public Object[] ProviderTypeArguments { get; set; }

        public String SerializerType { get; set; }

        public Object[] SerializerTypeArguments { get; set; }

        public TypeConstructorSignature[] ColumnNameFormatters { get; set; }

        public String[] TableNameFormatters { get; set; }

        public String[] DbSetNameFormatters { get; set; }

        public string ElementToGenerate { get; set; }

        public object ContextName { get; set; }

        public void MergeWith(GenerationOptions options)
        {
            if (options == null) { return; }

            //if(options.ColumnNameFormatters.Count() > 0)
            //{
            //    this.ColumnNameFormatters = this.ColumnNameFormatters.Concat(options.ColumnNameFormatters).ToArray();
            //}
            this.ColumnNameFormatters = options.ColumnNameFormatters ?? this.ColumnNameFormatters;
            this.TableNameFormatters = options.TableNameFormatters ?? this.TableNameFormatters;
            this.DbSetNameFormatters = options.DbSetNameFormatters ?? this.DbSetNameFormatters;
            this.ConnectionString = options.ConnectionString ?? this.ConnectionString;
            this.ContextName = options.ContextName ?? this.ContextName;
            this.ElementToGenerate = options.ElementToGenerate ?? this.ElementToGenerate;
            this.IgnoreTableRegex = options.IgnoreTableRegex ?? this.IgnoreTableRegex;
            this.ImplementingClassPath = options.ImplementingClassPath ?? this.ImplementingClassPath;
            this.Namespace = options.Namespace ?? this.Namespace;
            this.ProviderType = options.ProviderType ?? this.ProviderType;
            this.ProviderTypeArguments = options.ProviderTypeArguments ?? this.ProviderTypeArguments;
            this.SchemaName = options.SchemaName ?? this.SchemaName;
            this.SerializerType = options.SerializerType ?? this.SerializerType;
            this.SerializerTypeArguments = options.SerializerTypeArguments ?? this.SerializerTypeArguments;
            
        }
    }
}
