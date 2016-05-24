using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CExtensions.EFModelGenerator.Core;

namespace CExtensions.EFModelGenerator.Serializers
{
    public class CoreSerializer : AbstractSerializer
    {
        public CoreSerializer(string _nameSpace)
        {
            NameSpace = _nameSpace;
        }

        public String NameSpace { get; set; }

        public override String Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();

            ModelSerializer.SerializeUsings(sb);
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            ModelSerializer.SerializeTables(schema, sb);
            sb.AppendLine("");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
