using CExtensions.EFModelGenerator.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Column : ColumnMetadata
    {
        private IDictionary<string, Func<Column, string>> formatters = new Dictionary<string, Func<Column, string>>();

        private ColumnNameFormatter DEFAULT_FORMATTER = new RemoveUnderscoreNameFormatter();

        internal Column()
        {
            ColumnConfiguration = new ColumnConfiguration();
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
        internal ColumnConfiguration ColumnConfiguration { get; private set; }

        [JsonIgnore]
        public Table Table { get; internal set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsForeignKey { get; set; }

        [JsonIgnore]
        public String CLRType => GetPropertyType(DBType, DBDataScale);

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

        public string ForeignTableClrTypeName
        {
            get; set;
        }

        public string ForeignTableName
        {
            get; set;
        }

        public void AddFormatter(String pattern, Func<Column, string> ColumnFormatter)
        {
            if (!formatters.ContainsKey(pattern))
            {
                formatters.Add(pattern, ColumnFormatter);
            }
        }

        private String FormatColumnName()
        {
            var formatters = ColumnConfiguration.GetFormattersFor(this.TableName);

            foreach (var formatter in formatters)
            {
                if (formatter.IsApplicable(this))
                {
                    return formatter.Apply(this);
                }
            }

            return DEFAULT_FORMATTER.Apply(this);

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
