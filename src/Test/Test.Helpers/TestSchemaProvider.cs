using CExtensions.EFModelGenerator.Common;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Helpers
{
    public class TestSchemaProvider : AbstractProvider
    {
        List<Tuple<string, string, string>> ForeignKeys = new List<Tuple<string, string, string>>();

        List<Tuple<string, string>> PrimaryKeys = new List<Tuple<string, string>>();

        List<string> Tables = new List<string>();

        List<ColumnMetadata> Columns = new List<ColumnMetadata>();

        public TestSchemaProvider(string content)
        {
            using (StringReader sr = new StringReader(content))
            {
                CsvReader reader = new CsvReader(sr);
                reader.Configuration.HasHeaderRecord = false;

                while (reader.Read())
                {
                    string type = reader.GetField<string>(0);
                    if(type == "TABLE")
                    {
                        Tables.Add(reader.GetField<string>(1));
                    }
                    if (type == "COLUMN")
                    {
                        //COLUMN, Person, PERS_ID, number, 0, false
                        Columns.Add(GetTestmetdata(
                            reader.GetField<string>(1).Trim(),
                            reader.GetField<string>(2).Trim(),
                            reader.GetField<string>(3).Trim(),
                            reader.GetField<string>(4).Trim(),
                            reader.GetField<bool>(5)));
                    }
                    if (type == "FK")
                    {
                        //COLUMN, Person, PERS_ID, number, 0, false
                        ForeignKeys.Add(Tuple.Create<string, string, string>(
                            reader.GetField<string>(1).Trim(),
                            reader.GetField<string>(2).Trim(),
                            reader.GetField<string>(3).Trim()));
                    }
                    if (type == "PK")
                    {
                        //COLUMN, Person, PERS_ID, number, 0, false
                        PrimaryKeys.Add(Tuple.Create<string, string>(
                            reader.GetField<string>(1).Trim(),
                            reader.GetField<string>(2).Trim()));
                    }
                }
            }
                
        }

        public override IList<Tuple<string, string, string>> ListAllForeignKeys()
        {
            return ForeignKeys;
        }

        public override IList<Tuple<string, string>> ListAllPrimaryKeys()
        {
            return PrimaryKeys;
        }

        public override IList<ColumnMetadata> ListColumnsFor(string tableName)
        {
            var result = from c in Columns where c.TableName == tableName select c;

            return result.ToList();
        }

        public ColumnMetadata GetTestmetdata(string tableName, string name, string dbtype, string datascale, bool isNullable)
        {
            return new ColumnMetadata()
            {
                TableName = tableName,
                Name = name,
                DBType = dbtype,
                DBDataScale = datascale,
                IsNullable = isNullable
            };
        }

        public override IList<string> ListTableNames() 
        {
            List<string> disctintTables = Columns
                    .GroupBy(p => p.TableName)
                    .Select(g => g.First().TableName)
                    .ToList();

            return disctintTables;

        }
    }
}
