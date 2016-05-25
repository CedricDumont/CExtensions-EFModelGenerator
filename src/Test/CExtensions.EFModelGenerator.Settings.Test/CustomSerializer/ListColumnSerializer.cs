using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CExtensions.EFModelGenerator.Core;

namespace CExtensions.EFModelGenerator.Settings.Test.CustomSerializer
{
    public class ListColumnSerializer : AbstractSerializer
    {
        public ListColumnSerializer(string somInfo)
        {
            SomeInfo = somInfo;
        }

        private String SomeInfo { get; set; }

        public override string Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This serialier only list the table and it's columns");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine(SomeInfo);
            int tableCounter = 0;
            foreach (var table in schema.Tables)
            {
                tableCounter++;
                sb.AppendLine("");
                sb.AppendLine($"{tableCounter}. {table.Name}");
                int columnCounter = 1;
                foreach (var col in table.Columns)
                {
                    sb.AppendLine($"    {tableCounter}.{columnCounter++} {col.Name}");
                }
            }

            return sb.ToString();
        }
    }
}
