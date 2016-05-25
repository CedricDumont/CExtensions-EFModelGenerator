using CExtensions.EFModelGenerator.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class Column : ColumnMetadata
    {
        private IDictionary<string, Func<Column, string>> formatters = new Dictionary<string, Func<Column, string>>();

        internal Column()
        {
        }

        internal Column(string tableName, ColumnMetadata metadata)
        {
            TableName = tableName;
            Name = metadata.Name;
            DBType = metadata.DBType;
            DBDataScale = metadata.DBDataScale;
            IsNullable = metadata.IsNullable;
        }

        [JsonIgnore]
        internal FormatterCollection<Column> FormatterCollection { get; set; }

        [JsonIgnore]
        public Table Table { get; internal set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsForeignKey { get; set; }

        [JsonIgnore]
        public String CLRType => GetPropertyType(DBType, DBDataScale);

        [JsonIgnore]
        public String CLRTypeWithNullableMark
        {
            get
            {
                string isNullableMark = ""; 

                if(CLRType != "string")
                {
                    isNullableMark = (IsNullable ? "?" : "");
                }

                return CLRType + isNullableMark;
            }
        }

        [JsonIgnore]
        public String FormattedName => FormatColumnName();

        //[JsonIgnore]
        //public Table ForeignTable { get; set; }

        [JsonIgnore]
        public bool IsRequired
        {
            get
            {
                return !IsNullable;
            }
        }

        [JsonIgnore]
        public string TableCLRTypeName
        {
            get
            {
                return Table.CLRTypeName;
            }
        }

        [JsonIgnore]
        public Table ForeignTable { get; set; }

        public string ReferencedTableName { get; set; }

        public void AddFormatter(String pattern, Func<Column, string> ColumnFormatter)
        {
            if (!formatters.ContainsKey(pattern))
            {
                formatters.Add(pattern, ColumnFormatter);
            }
        }

        private String FormatColumnName()
        {
            var formatters = FormatterCollection.GetFormattersFor(this.TableName);

            string newColumnName = this.Name;

            foreach (var formatter in formatters)
            {
                if (formatter.IsApplicable(this, newColumnName))
                {
                    newColumnName = formatter.Apply(this, newColumnName);

                    if(formatter.SkipOtherFormatters(this, newColumnName))
                    {
                        break;
                    }
                }
            }

            //ensure name is not the same as enclosingType
            if(this.Table.CLRTypeName == newColumnName)
            {
                newColumnName =  newColumnName + "_" + newColumnName;
            }

            //if te name is a foreign key ref, add suffix _Key
            if(this.IsForeignKey)
            {
                newColumnName = newColumnName + "_Key";
            }

            return newColumnName;

        }

        public override string ToString()
        {
            return Table.ToString() + "." + FormattedName + $" [{this.Name}]";
        }

        string GetPropertyType(string sqlType, string dataScale)
        {
            string sysType = "string";
            sqlType = sqlType.ToLower();
            switch (sqlType)
            {
                case "bigint":
                    sysType = "long";
                    break;
                case "smallint":
                    sysType = "short";
                    break;
                case "int":
                    sysType = "int";
                    break;
                case "uniqueidentifier":
                    sysType = "Guid";
                    break;
                case "smalldatetime":
                case "datetime":
                case "date":
                    sysType = "DateTime";
                    break;
                case "float":
                    sysType = "double";
                    break;
                case "real":
                case "numeric":
                case "smallmoney":
                case "decimal":
                case "money":
                case "number":
                    sysType = "decimal";
                    break;
                case "tinyint":
                    sysType = "byte";
                    break;
                case "bit":
                    sysType = "bool";
                    break;
                case "image":
                case "binary":
                case "varbinary":
                case "timestamp":
                    sysType = "byte[]";
                    break;
            }

            if (sqlType == "number" && dataScale == "0")
                return "long";

            return sysType;
        }
    }
}
