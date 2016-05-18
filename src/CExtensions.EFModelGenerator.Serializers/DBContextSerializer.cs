using CExtensions.EFModelGenerator.Common;
using System;
using System.Text;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class DBContextSerializer : ISerializer
    {
        private const string TabClassDef = "   ";
        private const string TabClass = TabClassDef + "   ";
        private const string TabProperty = TabClass + "   ";

        public DBContextSerializer(string _nameSpace, string _contextName)
        {
            ContextName = _contextName;
            NameSpace = _nameSpace;
        }

        public String ContextName { get; set; }

        public String NameSpace { get; set; }

        public String Serialize(ISchema schema)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine("using System.Data.Common;");
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");

            sb.AppendLine(TabClassDef + $"public partial class {ContextName}: DbContext {{");

            //Collections
            foreach (var table in schema.Tables)
            {
                sb.AppendLine("");
                sb.AppendLine(TabClass + $"public IDbSet<{table.CLRTypeName}> {table.CollectionName} {{ get; set; }} // {table.Name} ");

            }

          
            sb.AppendLine("");
            sb.AppendLine(TabClass+ "// Constructors");
            writeConstructorSnippet(sb, ContextName);

            sb.AppendLine("");
            sb.AppendLine(TabClass + "partial void InitializePartial();");

            sb.AppendLine("");
            sb.AppendLine(TabClassDef + "}");

            sb.AppendLine("");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private void writeConstructorSnippet(StringBuilder sb, string contextName)
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
