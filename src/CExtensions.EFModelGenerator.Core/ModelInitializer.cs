using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CExtensions.EFModelGenerator.Core
{
    internal class ModelInitializer
    {
        public IProvider Provider { get; set; }

        public GenerationOptions Options { get; set; }

        internal ModelInitializer(IProvider provider, GenerationOptions options)
        {
            Options = options;
            Provider = provider;
        }

        public Schema Initialize(String schemaName)
        {
            Schema schema = new Schema(schemaName, Options);
            LoadTables(schema);
            LoadColumns(schema);
            LoadPrimaryKeys(schema);
            LoadForeignKeys(schema);
            ArrangeIntegrity(schema);
            return schema;

        }

        private void LoadTables(ISchema schema)
        {
            foreach (var table in Provider.ListTableNames())
            {
                if (!IgnoreTable(table))
                {
                    ITable tbl = new Table(schema, table, DefaultNameFormatter);
                    schema.Tables.Add(tbl);
                }
            }
        }

        private Boolean IgnoreTable(string table)
        {
            foreach (var item in Options.IgnoreTableRegex)
            {
                if(item.IsMatch(table))
                {
                    return true;
                }
            }

            return false;
        }

        private void LoadColumns(Schema schema)
        {
            foreach (var table in schema.Tables)
            {
                foreach (var columnMetadata in Provider.ListColumnsFor(table.Name))
                {
                    Column col = new Column(table, columnMetadata, schema.GeneratorOptions.ColumnConfiguration);
                    table.Columns.Add(col);
                }
            }
        }

        private void LoadPrimaryKeys(Schema schema)
        {
            IList<Tuple<string,string>> allPks = Provider.ListAllPrimaryKeys();

            var allPkColumns = from table in schema.Tables
                               from column in table.Columns
                               from pk in allPks
                               where (pk.Item1 == column.Table.Name
                               && column.Name == pk.Item2)
                               select column;

            foreach (var item in allPkColumns)
            {
                item.IsPrimaryKey = true;
            }

        }

        private void LoadForeignKeys(Schema schema)
        {
            IList<Tuple<string, string, string>> allFks = Provider.ListAllForeignKeys();

            var allFsColumn = from table in schema.Tables
                              from column in table.Columns
                              from fk in allFks
                              where (fk.Item1 == column.Table.Name
                              && column.Name == fk.Item2)
                              select new { Column = column, ReferencedTable = fk.Item3 };

            foreach (var item in allFsColumn)
            {
                item.Column.IsForeignKey = true;
                //find correcponding relational table in already loaded tables
                var referencedTable = (from t in schema.Tables where t.Name == item.ReferencedTable select t).FirstOrDefault();
                item.Column.ForeignTable = referencedTable;
            }

        }

        private void ArrangeIntegrity(Schema schema)
        {
            //check duplicate table names in collection
            foreach (var table in schema.Tables)
            {
                var samTable = (from t in schema.Tables where t.Name.ToUpper().Equals(table.Name.ToUpper()) select t);
                if (samTable.Count() > 1)
                {
                    var newList = samTable.ToList();
                    newList.RemoveAt(0);
                    foreach (var secondRUn in newList)
                    {
                        //TODO : not very pretty here 
                        ((Table)secondRUn).Info = "Duplicate";
                    }
                }
            }
        }

        private Func<String, String> DefaultNameFormatter = str =>
        {
            var yourString = str.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        };
    }
}
