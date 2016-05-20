using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using System;
using System.Linq;
using System.Text;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class ModelSerializer : AbstractSerializer
    {

        public ModelSerializer(string _nameSpace)
        {
            NameSpace = _nameSpace;
        }

        public String NameSpace { get; set; }

        public override String Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();
            string TabClass = "   ";
            string TabProperty = TabClass + "   ";
            sb.AppendLine("using System;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;          ");
            sb.AppendLine("using System.ComponentModel.DataAnnotations.Schema;   ");
            sb.AppendLine("using System.Collections.Generic;   ");
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
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
                    if(column.IsRequired)
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
            sb.AppendLine("");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
