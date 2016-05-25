using CExtensions.EFModelGenerator.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Model
{
    public class Schema
    {
        internal Schema() { }

        internal Schema(string name, GenerationOptions options)
        {
            this.Name = name;
            this.Tables = new List<Table>();
            GeneratorOptions = options;
        }

       

        internal void Init()
        {
            //Create formatters classes for columns
            FormatterCollection<Column> columnFormatters = new FormatterCollection<Column>();

            foreach (var constructorDescription in GeneratorOptions.ColumnNameFormatters)
            {
                var formatterType = Type.GetType(constructorDescription.Name);

                if(formatterType == null)
                {
                    throw new Exception($"Could not load type {constructorDescription.Name}");
                }

                INameFormatter<Column> instance;
                if (constructorDescription.ParamsForConstructor != null)
                {
                    instance = (INameFormatter<Column>)Activator.CreateInstance(formatterType, constructorDescription.ParamsForConstructor);
                }
                else
                {
                    instance = (INameFormatter<Column>)Activator.CreateInstance(formatterType);
                }
                columnFormatters.AddFormatter(instance);
            }

            FormatterCollection<Table> tableFormatters = new FormatterCollection<Table>();
            foreach (var formatterName in GeneratorOptions.TableNameFormatters)
            {
                var formatterType = Type.GetType(formatterName);

                if (formatterType == null)
                {
                    throw new Exception($"Could not load type {formatterName}");
                }

                var instance = (INameFormatter<Table>)Activator.CreateInstance(formatterType);

                tableFormatters.AddFormatter(instance);
            }

            FormatterCollection<Table> DbSetFormatters = new FormatterCollection<Table>();
            foreach (var formatterName in GeneratorOptions.DbSetNameFormatters)
            {
                var formatterType = Type.GetType(formatterName);

                if (formatterType == null)
                {
                    throw new Exception($"Could not load type {formatterName}");
                }

                var instance = (INameFormatter<Table>)Activator.CreateInstance(formatterType);

                DbSetFormatters.AddFormatter(instance);
            }

            foreach (var table in Tables)
            {
                //create the reverse link to table
                table.FormatterCollection = tableFormatters;
                table.DbSetFormatters = DbSetFormatters;
            }


            foreach (var col in AllColumns)
            {
                //create the reverse link to table
                Table table = FindTable(col.TableName);
                col.Table = table;
                col.FormatterCollection = columnFormatters;
            }

            //init foreignTables
            foreach (var col in AllColumns.Where(c => c.IsForeignKey))
            {
                var referencedTable = (from t in Tables where t.Name == col.ReferencedTableName select t).FirstOrDefault();

                col.ForeignTable = referencedTable;
            }
        }

        public String Name { get; set; }

        public GenerationOptions GeneratorOptions { get; set; }

        public List<Table> Tables { get; set; }

        [JsonIgnore]
        public List<Column> AllColumns
        {
            get
            {
                List<Column> mergedColumns = new List<Column>();
                Tables.ForEach(t =>
                {
                    mergedColumns.AddRange(t.Columns);
                });
                return mergedColumns;
            }
        }

        internal Table FindTable(string tableName)
        {
            var table = (from t in Tables where t.Name == tableName select t).FirstOrDefault();

            return table;
        }

        public List<Column> RelatedTablesFor(Table table)
        {
           
                var tables = from c in this.AllColumns
                             where c.ForeignTable?.Name == table.Name
                             select c;

                return tables.ToList();
        }

        public IEnumerable<InverseProperty> InversePropertiesFor(Table table)
        {
                List<InverseProperty> result = new List<InverseProperty>();

                if (this.RelatedTablesFor(table).Count() > 0)
                {
                    int counter = 1;
                    List<String> tracker = new List<string>();
                    foreach (var reverseNavigation in this.RelatedTablesFor(table))
                    {
                        var propertyName = reverseNavigation.TableCLRTypeName + ((reverseNavigation.TableCLRTypeName == table.CLRTypeName) ? $"_{counter++}" : "");
                        if (tracker.Contains(propertyName))
                        {
                            propertyName += counter++;
                        }
                        tracker.Add(propertyName);

                        result.Add(new InverseProperty()
                        {
                            PropertyName = propertyName,
                            ReversePropertyName = reverseNavigation.FormattedName,
                            ReverseCLRType = reverseNavigation.TableCLRTypeName
                        });
                    }

                }

                return result;
        }

    }
}
