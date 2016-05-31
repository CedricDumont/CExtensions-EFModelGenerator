using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CExtensions.EFModelGenerator.Providers
{
    public class SqlDataProvider : AbstractProvider
    {
        #region queries

        private const string TABLE_SQL = @"SELECT t.name as TABLE_NAME
                                              FROM sys.tables AS t
                                              INNER JOIN sys.schemas AS s
                                              ON t.[schema_id] = s.[schema_id]
                                              WHERE s.name = N'{0}';";

        private const String COLUMN_SQL = @"SELECT 
                                            TABLE_NAME as TableName, 
                                            COLUMN_NAME as ColumnName,
                                            DATA_TYPE as DataType,
                                            NUMERIC_SCALE as DataScale,
                                            IS_NULLABLE as IsNullable,
                                            CAST(ISNULL(CHARACTER_MAXIMUM_LENGTH, 0) AS INT) as MaxLength,
                                            CAST(ISNULL(NUMERIC_PRECISION, 0) AS INT) AS [Precision]
                                            FROM INFORMATION_SCHEMA.COLUMNS
                                            WHERE TABLE_SCHEMA='{0}'
                                            AND TABLE_NAME = '{1}'
                                            ";

        private const String PK_SQL = @"SELECT Tab.TABLE_NAME, Col.COLUMN_NAME from 
                                        INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, 
                                        INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col 
                                    WHERE 
                                        Col.Constraint_Name = Tab.Constraint_Name
                                        AND Col.Table_Name = Tab.Table_Name
                                        AND Constraint_Type = 'PRIMARY KEY'
                                    ";

        private const String FK_SQL = @"                 
                                    SELECT 
                                       OBJECT_NAME(f.parent_object_id) as TABLE_NAME,
                                       COL_NAME(fc.parent_object_id,fc.parent_column_id) as COLUMN_NAME,
                                       OBJECT_NAME(f.referenced_object_id) as R_TABLE_NAME
                                    FROM 
                                       sys.foreign_keys AS f
                                    INNER JOIN 
                                       sys.foreign_key_columns AS fc 
                                          ON f.OBJECT_ID = fc.constraint_object_id
                                    INNER JOIN 
                                       sys.tables t 
                                          ON t.OBJECT_ID = fc.referenced_object_id
                                    ";


        #endregion

        public SqlDataProvider(String connString, string schema)
        {
            ConnectionString = connString;
            Schema = schema;
        }

        public String ConnectionString { get; private set; }

        public String Schema { get; private set; }

        public override IList<string> ListTableNames()
        {
            SqlConnection dbcon = new SqlConnection(ConnectionString);

            List<String> result = new List<string>();

            try
            {
                dbcon.Open();

                var formatQuery = string.Format(TABLE_SQL, Schema);

                using (var TableCmd = new SqlCommand(formatQuery, dbcon))
                {
                    using (var rdr = TableCmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(rdr["TABLE_NAME"].ToString());
                        }
                    }
                }
            }
            finally
            {
                dbcon.Close();
            }

            return result;
        }

        public override IList<ColumnMetadata> ListColumnsFor(string tableName)
        {
            SqlConnection dbcon = new SqlConnection(ConnectionString);

            List<ColumnMetadata> result = new List<ColumnMetadata>();

            try
            {
                dbcon.Open();

                String formatedColumnCommand = String.Format(COLUMN_SQL, Schema, tableName);

                using (var ColumnCmd = new SqlCommand(formatedColumnCommand, dbcon))
                {
                    using (var colRdr = ColumnCmd.ExecuteReader())
                    {
                        while (colRdr.Read())
                        {
                            var col = new ColumnMetadata()
                            {
                                Name = colRdr["ColumnName"].ToString(),
                                DBType = colRdr["DataType"].ToString(),
                                DBDataScale = colRdr["DataScale"].ToString(),
                                IsNullable = "YES".Equals(colRdr["IsNullable"].ToString()),
                                MaxLength = Int32.Parse(colRdr["MaxLength"]?.ToString()),
                                Precision = Int32.Parse(colRdr["Precision"]?.ToString())
                            };

                            result.Add(col);
                        }
                    }
                }
            }
            finally
            {
                dbcon.Close();
            }

            return result;
        }

        public override IList<Tuple<string,string>> ListAllPrimaryKeys()
        {
            SqlConnection dbcon = new SqlConnection(ConnectionString);

            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            try
            {
                dbcon.Open();

                using (var PkCmd = new SqlCommand(PK_SQL, dbcon))
                {
                    using (var PkReader = PkCmd.ExecuteReader())
                    {
                        while (PkReader.Read())
                        {
                            var myStruct = Tuple.Create<string, string>(PkReader["TABLE_NAME"].ToString(), PkReader["COLUMN_NAME"].ToString());
                                
                            result.Add(myStruct);
                        }
                    }
                }
            }
            finally
            {
                dbcon.Close();
            }

            return result;
        }

        public override IList<Tuple<string, string, string>> ListAllForeignKeys()
        {
            SqlConnection dbcon = new SqlConnection(ConnectionString);

            IList<Tuple<string, string, string>> result = new List<Tuple<string, string, string>>();
            try
            {
                dbcon.Open();

                using (var FKCmd = new SqlCommand(FK_SQL, dbcon))
                {
                    using (var FkReader = FKCmd.ExecuteReader())
                    {
                        while (FkReader.Read())
                        {
                            var fk = Tuple.Create<string, string, string>(
                                 FkReader["TABLE_NAME"].ToString(),
                                 FkReader["COLUMN_NAME"].ToString(),
                                 FkReader["R_TABLE_NAME"].ToString()
                            );

                            result.Add(fk);
                        }
                    }
                }
            }
            finally
            {
                dbcon.Close();
            }

            return result;
        }
    }
}
