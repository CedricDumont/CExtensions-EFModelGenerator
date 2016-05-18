using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Column : IColumn
    {
        private IDictionary<string, Func<Column, string>> formatters = new Dictionary<string, Func<Column, string>>();

        private ColumnNameFormatter DEFAULT_FORMATTER = new RemoveUnderscoreNameFormatter();

        internal Column(ITable table, ColumnMetadata metadata, ColumnConfiguration columnConfiguration)
        {
            Table = table;
            Name = metadata.Name;
            DBType = metadata.DataType;
            DBDataScale = metadata.DataScale;
            IsNullable = metadata.IsNullable;
            ColumnConfiguration = columnConfiguration;
        }

        internal ColumnConfiguration ColumnConfiguration { get; private set; }

        public ITable Table { get; private set; }

        public String Name { get; private set; }

        public String DBType { get; set; }

        public String DBDataScale { get; set; }

        public String CLRType => GetPropertyType(DBType, DBDataScale);

        public String FormattedName => FormatColumnName();

        public bool IsNullable { get; internal set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsForeignKey { get; set; }

        public ITable ForeignTable { get; set; }

        public bool IsRequired
        {
            get
            {
                return !IsNullable;
            }
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
            var formatters = ColumnConfiguration.GetFormattersFor(this.Table.Name);

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
