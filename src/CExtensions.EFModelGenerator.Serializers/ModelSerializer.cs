using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class ModelSerializer : AbstractSerializer
    {

        private const string TabClass = "   ";

        private const string TabProperty = TabClass + "   ";

        public ModelSerializer(string _nameSpace)
        {
            NameSpace = _nameSpace;
        }

        public String NameSpace { get; set; }

        public override String Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();

            SerializeUsings(sb);
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            SerializeTables(schema, sb);
            sb.AppendLine("");
            sb.AppendLine("}");
            return sb.ToString();
        }

        public static void SerializeTables(Schema schema, StringBuilder sb)
        {
            foreach (var table in schema.Tables)
            {
                sb.AppendLine("");
                sb.AppendLine(TabClass + "[Table(\"" + table.Name + "\")]");
                sb.AppendLine(TabClass + "public partial class " + table.CLRTypeName);
                sb.AppendLine(TabClass + "{");

                foreach (var column in table.PrimaryKeys)
                {
                    sb.AppendLine("");
                    sb.AppendLine(TabProperty + "[Key]");
                    sb.AppendLine(TabProperty + $"[Column(\"{column.Name}\")]");
                    var comment = $" // {table.Name}.{column.Name} (PrimaryKey)";
                    sb.AppendLine(TabProperty + $"public {column.CLRType} {column.FormattedName} {{ get;set; }} {comment}");

                }

                foreach (var column in table.DataColumns)
                {
                    sb.AppendLine("");
                    if (column.IsRequired)
                    {
                        sb.AppendLine(TabProperty + "[Required]");
                    }
                    sb.AppendLine(TabProperty + $"[Column(\"{column.Name}\")]");
                    var comment = $" // {table.Name}.{column.Name}";
                    sb.AppendLine(TabProperty + $"public {column.CLRType} {column.FormattedName} {{ get;set; }}  {comment}");
                }

                if (table.ForeignKeys.Count() > 0)
                {
                    foreach (var fk in table.ForeignKeys)
                    {
                        sb.AppendLine("");
                        sb.AppendLine(TabProperty + $"[Column(\"{fk.ColumnName}\")]");
                        sb.AppendLine(TabProperty + $"public {fk.ColumnCLRType} {fk.ForeignKeyName} {{ get;set; }} {fk.Comment}");
                    }

                    sb.AppendLine("");
                    sb.AppendLine(TabProperty + "// ForeignKeys");

                    foreach (var fk in table.ForeignKeys)
                    {
                        sb.AppendLine("");
                        sb.AppendLine(TabProperty + $"[ForeignKey(\"{fk.ForeignKeyName}\")]");
                        sb.AppendLine(TabProperty + "public virtual " + fk.ReferencedCLRName + " " + fk.PropertyName + " { get; set; }");

                    }
                }

                if (schema.InversePropertiesFor(table).Count() > 0)
                {
                    sb.AppendLine("");
                    sb.AppendLine(TabProperty + "// Reverse Navigation");
                    foreach (var reverseNavigation in schema.InversePropertiesFor(table))
                    {
                        sb.AppendLine("");
                        sb.AppendLine(TabProperty + $"[InverseProperty(\"{reverseNavigation.ReversePropertyName}\")]");
                        sb.AppendLine(TabProperty + $"public virtual List<{reverseNavigation.ReverseCLRType}> "
                            + reverseNavigation.PropertyName
                            + " { get; set; }");
                    }
                }

                sb.AppendLine("");
                sb.AppendLine(TabClass + "}");
            }
        }

        public static void SerializeUsings(StringBuilder sb)
        {
            foreach (var entry in GetUsings())
            {
                sb.AppendLine(entry);
            }
        }

        public static IList<string> GetUsings()
        {
            List<string> usings = new List<string>();
            usings.Add("using System;");
            usings.Add("using System.ComponentModel.DataAnnotations;");
            usings.Add("using System.ComponentModel.DataAnnotations.Schema;");
            usings.Add("using System.Collections.Generic;");
            usings.Sort();
            usings.Reverse();
            return usings;
        }
    }
}
