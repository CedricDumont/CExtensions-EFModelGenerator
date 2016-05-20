//using System;
//using System.Collections.Generic;

//namespace CExtensions.EFModelGenerator.Common
//{
//    public interface IProvider
//    {
//        /// <summary>
//        /// List of all tables. you can filter them here if you want or throught the generation options.
//        /// </summary>
//        /// <returns></returns>
//        IList<string> ListTableNames();

//        /// <summary>
//        /// Return the columns of the table passed as parameter.
//        /// the returned columns must cotain all columns (data column, primary key, foreign keys)
//        /// </summary>
//        /// <param name="tableName"></param>
//        /// <returns></returns>
//        IList<ColumnMetadata> ListColumnsFor(string tableName);

//        /// <summary>
//        /// Must return a list of Tuple containing
//        /// 1. The table Name
//        /// 2. the column name (of the foreign key)
//        /// 3. the referenced table name
//        /// </summary>
//        /// <returns></returns>
//        IList<Tuple<string, string, string>> ListAllForeignKeys();

//        /// <summary>
//        /// Return a list tuple qith all the primary keys:
//        /// 1. the table name
//        /// 2. the name of the primary key
//        /// </summary>
//        /// <returns></returns>
//        IList<Tuple<string,string>> ListAllPrimaryKeys();

        
//    }
//}