using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CExtensions.EFModelGenerator.Model;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class BreezeControllerSerializer : AbstractSerializer
    {
        public BreezeControllerSerializer(string _nameSpace, string controllerName, string contextName)
        {
            NameSpace = _nameSpace;
            ControllerName = controllerName;
            ContextName = contextName;
        }

        public String NameSpace { get; set; }
        public String ControllerName { get; set; }

        public String ContextName { get; set; }

        public override string Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();
            //usings
            SerializeUsings(sb);
            //code
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            sb.AppendLine(Constants.TabClass + "[BreezeController]");
            sb.AppendLine(Constants.TabClass + "[EnableCors(origins: \"*\", headers: \"*\", methods: \"*\")]");
            sb.AppendLine(Constants.TabClass + $"public partial class {ControllerName} : ApiController");
            sb.AppendLine(Constants.TabClass + "{");
            sb.AppendLine(Constants.TabProperty + $"readonly EFContextProvider<{ContextName}> _contextProvider;");
            sb.AppendLine("");
            sb.AppendLine(Constants.TabProperty + $"public {ControllerName}(EFContextProvider<{ContextName}> contextProvider)");
            sb.AppendLine(Constants.TabProperty + "{");
            sb.AppendLine(Constants.TabBody + "_contextProvider = contextProvider;");
            sb.AppendLine(Constants.TabProperty + "}");
            sb.AppendLine("");

            //metadata
            sb.AppendLine(Constants.TabProperty + "[HttpGet]");
            sb.AppendLine(Constants.TabProperty + "public string Metadata()");
            sb.AppendLine(Constants.TabProperty + "{");
            sb.AppendLine(Constants.TabBody + "var metadata = _contextProvider.Metadata();");
            sb.AppendLine(Constants.TabBody + "return metadata;");
            sb.AppendLine(Constants.TabProperty + "}");

            foreach (var table in schema.Tables)
            {
                sb.AppendLine("");
                sb.AppendLine(Constants.TabProperty + "[HttpGet]");
                sb.AppendLine(Constants.TabProperty + $"public IQueryable<{table.CLRTypeName}> {table.CollectionName}()");
                sb.AppendLine(Constants.TabProperty + "{");
                sb.AppendLine(Constants.TabBody + $"return _contextProvider.Context.{table.CollectionName};");
                sb.AppendLine(Constants.TabProperty + "}");
            }

            //SaveChanges
            sb.AppendLine("");
            sb.AppendLine(Constants.TabProperty + "[HttpPost]");
            sb.AppendLine(Constants.TabProperty + "public SaveResult SaveChanges(JObject saveBundle)");
            sb.AppendLine(Constants.TabProperty + "{");
            sb.AppendLine(Constants.TabBody + "return _contextProvider.SaveChanges(saveBundle);");
            sb.AppendLine(Constants.TabProperty + "}");

            sb.AppendLine(Constants.TabClass + "}");
            sb.AppendLine("}");




            return sb.ToString();

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

            usings.Add("using Breeze.ContextProvider;");
            usings.Add("using Breeze.ContextProvider.EF6;");
            usings.Add("using Breeze.WebApi2;");
            usings.Add("using Newtonsoft.Json.Linq;");
            usings.Add("using System;");
            usings.Add("using System.Linq;");
            usings.Add("using System.Web.Http;");
            usings.Add("using System.Web.Http.Cors;");

            usings.Sort();
            usings.Reverse();
            return usings;
        }
    }
}
