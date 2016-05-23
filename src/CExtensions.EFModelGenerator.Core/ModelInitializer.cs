using CExtensions.EFModelGenerator.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CExtensions.EFModelGenerator.Core
{
    internal class ModelInitializer
    {
        public Object Provider { get; set; }

        public GenerationOptions Options { get; set; }

        internal ModelInitializer(Object provider, GenerationOptions options)
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

        private void LoadTables(Schema schema)
        {
            var SerializedTableList = (string)Utils.CallMethodOnObject(Provider, "SerializedTableList", null);

            var tableList = (IList<string>)JsonConvert.DeserializeObject< IList<string>>(SerializedTableList);

            foreach (var table in tableList)
            {
                if (!IgnoreTable(table))
                {
                    Table tbl = new Table();
                    tbl.Init(table);
                    schema.Tables.Add(tbl);
                }
            }
        }

        private Boolean IgnoreTable(string table)
        {
            foreach (var item in Options.IgnoreTableRegex)
            {
                var regex = new Regex(item, RegexOptions.IgnoreCase);

                if (regex.IsMatch(table))
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
                var serializedColumnList = (string)Utils.CallMethodOnObject(Provider, "SerializedColumnsFor", new object[] { table.Name });

                IList<ColumnMetadata> columnList = JsonConvert.DeserializeObject<IList<ColumnMetadata>>(serializedColumnList);

                foreach (var columnMetadata in columnList)
                {
                    Column col = new Column(table.Name, columnMetadata);
                    table.Columns.Add(col);
                }
            }
        }

        private void LoadPrimaryKeys(Schema schema)
        {
            var SeruializedallPks = (string)Utils.CallMethodOnObject(Provider, "SerializedPrimaryKeys", null);

            IList<Tuple<string, string>> allPks = JsonConvert.DeserializeObject< IList<Tuple<string, string>>>(SeruializedallPks);

            //IList<Tuple<string,string>> allPks = Provider.ListAllPrimaryKeys();

            var allPkColumns = from table in schema.Tables
                               from column in table.Columns
                               from pk in allPks
                               where (pk.Item1 == column.TableName
                               && column.Name == pk.Item2)
                               select column;

            foreach (var item in allPkColumns)
            {
                item.IsPrimaryKey = true;
            }

        }

        private void LoadForeignKeys(Schema schema)
        {
            var SerializedAllFks = (string)Utils.CallMethodOnObject(Provider, "SerializedForeignKeys", null);

            IList<Tuple<string, string, string>> allFks = JsonConvert.DeserializeObject< IList<Tuple<string, string, string>>>(SerializedAllFks);


            var allFsColumn = from table in schema.Tables
                              from column in table.Columns
                              from fk in allFks
                              where (fk.Item1 == column.TableName
                              && column.Name == fk.Item2)
                              select new { Column = column, ReferencedTable = fk.Item3 };

            foreach (var item in allFsColumn)
            {
                item.Column.IsForeignKey = true;
                //find correcponding relational table in already loaded tables
                var referencedTable = (from t in schema.Tables where t.Name == item.ReferencedTable select t).FirstOrDefault();
                item.Column.ForeignTableClrTypeName = referencedTable.CLRTypeName;
                item.Column.ForeignTableName = referencedTable.Name;
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

       
    }
}
