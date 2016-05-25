using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public abstract class AbstractProvider 
    {

        public string SerializedTableList()
        {
            var list = this.ListTableNames();

            return JsonConvert.SerializeObject(list);
        }

        public string SerializedPrimaryKeys()
        {
            var list = this.ListAllPrimaryKeys();

            return JsonConvert.SerializeObject(list);
        }

        public string SerializedForeignKeys()
        {
            var list = this.ListAllForeignKeys();

            return JsonConvert.SerializeObject(list);
        }

        public string SerializedColumnsFor(string tablename)
        {
            var list = this.ListColumnsFor(tablename);

            return JsonConvert.SerializeObject(list);
        }

        public abstract IList<string> ListTableNames();

        public abstract IList<ColumnMetadata> ListColumnsFor(string tableName);

        public abstract IList<Tuple<string, string, string>> ListAllForeignKeys();

        public abstract IList<Tuple<string, string>> ListAllPrimaryKeys();
    }
}
