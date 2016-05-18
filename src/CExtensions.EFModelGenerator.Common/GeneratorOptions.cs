using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Common
{
    public class GenerationOptions
    {
        public GenerationOptions()
        {
            ColumnConfiguration = new ColumnConfiguration();
            IgnoreTableRegex = new List<Regex>();
        }

        public ColumnConfiguration ColumnConfiguration { get; set; }

        public IList<Regex> IgnoreTableRegex { get; set; }

        public String ProviderType { get; set; }

        public Object[] ProviderTypeArguments { get; set; }

        public String SerializerType { get; set; }

        public Object[] SerializerTypeArguments { get; set; }

        public string SchemaName { get; set; }
    }
}
