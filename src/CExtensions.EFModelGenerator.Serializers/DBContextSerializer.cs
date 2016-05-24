using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class DBContextSerializer : AbstractSerializer
    {
        private const string TabClassDef = Constants.TabClass;
        private const string TabClass = TabClassDef + Constants.TabClass;
        private const string TabProperty = TabClass + Constants.TabProperty;

        public DBContextSerializer(string _nameSpace, string _contextName)
        {
            ContextName = _contextName;
            NameSpace = _nameSpace;
        }

        public String ContextName { get; set; }

        public String NameSpace { get; set; }

        public override String Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();

            SerializeUsings(sb);
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");

            SerializeDbContext(schema, ContextName, sb);

            sb.AppendLine("");
            sb.AppendLine("}");

            return sb.ToString();
        }

        public static void SerializeDbContext(Schema schema, string contextName, StringBuilder sb)
        {
            sb.AppendLine(TabClassDef + $"public partial class {contextName}: DbContext {{");

            //Collections
            foreach (var table in schema.Tables)
            {
                sb.AppendLine("");
                sb.AppendLine(TabClass + $"public IDbSet<{table.CLRTypeName}> {table.CollectionName} {{ get; set; }} // {table.Name} ");
            }

            sb.AppendLine("");
            sb.AppendLine(TabClass + "// Constructors");
            writeConstructorSnippet(sb, contextName);

            sb.AppendLine("");
            sb.AppendLine(TabClass + "partial void InitializePartial();");

            sb.AppendLine("");
            sb.AppendLine(TabClassDef + "}");
        }

        private static void SerializeUsings(StringBuilder sb)
        {
            foreach (var entry in GetUsings())
            {
                sb.AppendLine(entry);
            }
        }

        public static IList<string> GetUsings()
        {
            List<string> usings = new List<string>();
            usings.Add("using System.Data.Entity;");
            usings.Add("using System.Data.Common;");
            usings.Sort();
            usings.Reverse();
            return usings;
        }

        private static void writeConstructorSnippet(StringBuilder sb, string contextName)
        {
            sb.AppendLine(TabClass + $"public {contextName}() : base()");
            sb.AppendLine(TabClass + "{");
            sb.AppendLine(TabProperty + "InitializePartial();");
            sb.AppendLine(TabClass + "}");

            sb.AppendLine(TabClass + "");
            sb.AppendLine(TabClass + $"public {contextName}(string connectionString) : base(connectionString)");
            sb.AppendLine(TabClass + "{");
            sb.AppendLine(TabProperty + "InitializePartial();");
            sb.AppendLine(TabClass + "}");

            sb.AppendLine(TabClass + "");
            sb.AppendLine(TabClass + $"public {contextName}(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)");
            sb.AppendLine(TabClass + "{");
            sb.AppendLine(TabProperty + "InitializePartial();");
            sb.AppendLine(TabClass + "}");

            sb.AppendLine(TabClass + "");
            sb.AppendLine(TabClass + $"public {contextName}(DbConnection existingConn) : base(existingConn, true)");
            sb.AppendLine(TabClass + "{");
            sb.AppendLine(TabProperty + "InitializePartial();");
            sb.AppendLine(TabClass + "}");

            sb.AppendLine(TabClass + "");
            sb.AppendLine(TabClass + "protected override void Dispose(bool disposing)");
            sb.AppendLine(TabClass + "{");
            sb.AppendLine(TabProperty + "base.Dispose(disposing);");
            sb.AppendLine(TabClass + "}");
        }
    }
}
