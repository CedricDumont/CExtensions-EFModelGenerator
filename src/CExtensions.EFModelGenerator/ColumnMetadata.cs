using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class ColumnMetadata
    {
        public string TableName { get; set; }

        public String Name { get; set; }

        public String DBType { get; set; }

        public String DBDataScale { get; set; }

        public bool IsNullable { get; set; }

    }
}
