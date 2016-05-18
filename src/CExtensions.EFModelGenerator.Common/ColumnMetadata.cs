using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Common
{
    public class ColumnMetadata
    {
        public String Name { get; set; }

        public String DataType { get; set; }

        public String DataScale { get; set; }

        public bool IsNullable { get; set; }

    }
}
