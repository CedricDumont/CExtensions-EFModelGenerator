using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class GenerationOptions
    {
        public GenerationOptions()
        {
          //  ColumnConfiguration = new ColumnConfiguration();
            IgnoreTableRegex = new string[0];
            ColumnNameFormatters = new string[0];
            TableNameFormatters = new string[0];
        }
        public String ConnectionString { get; set; }

        public string SchemaName { get; set; }

        public string Namespace { get; set; }

        public string ImplementingClassPath { get; set; }

    //    public ColumnConfiguration ColumnConfiguration { get; set; }

        public string[] IgnoreTableRegex { get; set; }

        public String ProviderType { get; set; }

        public Object[] ProviderTypeArguments { get; set; }

        public String SerializerType { get; set; }

        public Object[] SerializerTypeArguments { get; set; }

        public String[] ColumnNameFormatters { get; set; }

        public String[] TableNameFormatters { get; set; }


    }
}
