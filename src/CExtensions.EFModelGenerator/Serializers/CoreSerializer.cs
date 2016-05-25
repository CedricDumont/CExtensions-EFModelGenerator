﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CExtensions.EFModelGenerator;
using CExtensions.EFModelGenerator.Model;

namespace CExtensions.EFModelGenerator.Serializers
{

    public class CoreSerializer : AbstractSerializer
    {
        
        public CoreSerializer(string mode,
            string _nameSpace, string contextName)
        {
            this.NameSpace = _nameSpace;
            this.ContextName = contextName;
            if(mode == null)
            {
                SerializationType = ElementToGenerateEnum.All;
            }
            else if (mode.ToUpper().Equals("MODEL"))
            {
                SerializationType = ElementToGenerateEnum.Model;
            }
            else if (mode.ToUpper().Equals("DBCONTEXT"))
            {
                SerializationType = ElementToGenerateEnum.DbContext;
            }
            else
            {
                SerializationType = ElementToGenerateEnum.All;
            }
           
        }

        public String NameSpace { get; set; }

        public String ContextName { get; set; }

        public ElementToGenerateEnum SerializationType { get; set; }

        public override String Serialize(Schema schema)
        {
            StringBuilder sb = new StringBuilder();

            SerializeUsings(sb, SerializationType);
            sb.AppendLine("");
            sb.AppendLine($"namespace {NameSpace}");
            sb.AppendLine("{");
            ModelSerializer.SerializeTables(schema, sb);
            sb.AppendLine("");
            if(DoSerializeDbContext)
            {
                DBContextSerializer.SerializeDbContext(schema, ContextName, sb);
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        public bool DoSerializeDbContext
        {
           get
            {
                return this.SerializationType == ElementToGenerateEnum.DbContext ||
                    this.SerializationType == ElementToGenerateEnum.All;
            }
        }

        private static void SerializeUsings(StringBuilder sb, ElementToGenerateEnum mode)
        {
            foreach (var entry in GetUsings(mode))
            {
                sb.AppendLine(entry);
            }
        }

        public static IList<string> GetUsings(ElementToGenerateEnum mode)
        {
            IList<string> usingsFromModelSerializer = new List<string>();
            IList<string> usingsFromDBContextSerializer = new List<string>();
            if (mode == ElementToGenerateEnum.Model || mode == ElementToGenerateEnum.All)
            {
               usingsFromModelSerializer = ModelSerializer.GetUsings();
            }
            if (mode == ElementToGenerateEnum.DbContext || mode == ElementToGenerateEnum.All)
            {
               usingsFromDBContextSerializer = DBContextSerializer.GetUsings();
            }

            List<string> resultUsings = usingsFromModelSerializer.Union(usingsFromDBContextSerializer).ToList();
            resultUsings.Sort();
            resultUsings.Reverse();

            return resultUsings;
        }
    }
}
