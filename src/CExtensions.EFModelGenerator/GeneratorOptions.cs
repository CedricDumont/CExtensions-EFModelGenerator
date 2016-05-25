﻿using System;
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
            ColumnNameFormatters = new string[0];
            TableNameFormatters = new string[0];
            DbSetNameFormatters = new string[0];
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

        public String[] ColumnNameFormatters { get; set; }

        public String[] TableNameFormatters { get; set; }

        public String[] DbSetNameFormatters { get; set; }

        public string ElementToGenerate { get; set; }

        public object ContextName { get; set; }
    }
}
