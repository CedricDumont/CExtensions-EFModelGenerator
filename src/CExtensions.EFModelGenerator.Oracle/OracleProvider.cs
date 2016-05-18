using CExtensions.EFModelGenerator.Common;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Oracle
{
    public class OracleProvider : IProvider
    {
        #region queries

        private const string TABLE_SQL = @"select TABLE_NAME, 'Table' TABLE_TYPE, USER TABLE_SCHEMA
                                from USER_TABLES 
                                order by TABLE_NAME";

        private const String COLUMN_SQL = @"select table_name TableName, 
                                     column_name ColumnName, 
                                     data_type DataType, 
                                     data_scale DataScale,
                                     nullable IsNullable
                                     from USER_TAB_COLS utc 
                                     where table_name = '{0}'
                                     order by column_id";

        private const String PK_SQL = @"SELECT tbl1.table_name, tbl2.column_name
                                FROM user_tab_columns t, all_constraints tbl1, all_cons_columns tbl2
                                WHERE tbl1.table_name = t.table_name AND t.column_name= tbl2.column_name
                                AND tbl1.constraint_type = 'P' AND tbl1.owner = tbl2.owner AND
                                tbl1.constraint_name = tbl2.constraint_name";

        private const String FK_SQL = @"SELECT a.table_name , a.column_name 
                                  , a.constraint_name, c.owner, 
                                   -- referenced pk
                                   c.r_owner, c_pk.table_name r_table_name, c_pk.constraint_name r_pk
                              FROM all_cons_columns a
                              JOIN all_constraints c ON a.owner = c.owner
                                                    AND a.constraint_name = c.constraint_name
                              JOIN all_constraints c_pk ON c.r_owner = c_pk.owner
                                                       AND c.r_constraint_name = c_pk.constraint_name
                             WHERE c.constraint_type = 'R'
                             and c.owner = 'CSOV'";


        #endregion

        public OracleProvider(String connString)
        {
            ConnectionString = connString;
        }

        public String ConnectionString { get; private set; }

        public IList<string> ListTableNames()
        {
            OracleConnection dbcon = new OracleConnection(ConnectionString);

            List<String> result = new List<string>();

            try
            {
                dbcon.Open();

                using (var TableCmd = new OracleCommand(TABLE_SQL, dbcon))
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

        public IList<ColumnMetadata> ListColumnsFor(string tableName)
        {
            OracleConnection dbcon = new OracleConnection(ConnectionString);

            List<ColumnMetadata> result = new List<ColumnMetadata>();

            try
            {
                dbcon.Open();

                String formatedColumnCommand = String.Format(COLUMN_SQL, tableName);

                using (var ColumnCmd = new OracleCommand(formatedColumnCommand, dbcon))
                {
                    using (var colRdr = ColumnCmd.ExecuteReader())
                    {
                        while (colRdr.Read())
                        {
                            var col = new ColumnMetadata()
                            {
                                Name = colRdr["ColumnName"].ToString(),
                                DataType = colRdr["DataType"].ToString(),
                                DataScale = colRdr["DataScale"].ToString(),
                                IsNullable = "Y".Equals(colRdr["IsNullable"].ToString())
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

        public IList<Tuple<string,string>> ListAllPrimaryKeys()
        {
            OracleConnection dbcon = new OracleConnection(ConnectionString);

            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            try
            {
                dbcon.Open();

                using (var PkCmd = new OracleCommand(PK_SQL, dbcon))
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

        public IList<Tuple<string,string,string>> ListAllForeignKeys()
        {
            OracleConnection dbcon = new OracleConnection(ConnectionString);

            IList<Tuple<string, string, string>> result = new List<Tuple<string, string, string>>();
            try
            {
                dbcon.Open();

                using (var FKCmd = new OracleCommand(FK_SQL, dbcon))
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
