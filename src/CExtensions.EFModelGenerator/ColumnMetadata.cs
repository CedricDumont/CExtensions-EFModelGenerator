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

        public int MaxLength { get; set; }

        public int Precision { get; set; }

        public int? Scale
        {
            get
            {
                int? scale = null;

                if(DBDataScale != null)
                {
                    scale = Int32.Parse(DBDataScale);
                }

                return scale;
            }
        }



    }
}
