using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Model
{
    public class ForeignKey 
    {
        internal ForeignKey(Column column)
        {
            //this.Table = table;
            this.Column = column;
        }

        // private Table Table { get; set; }

        public Column Column { get; set; }

       public String ForeignKeyName => Column.FormattedName;

        public String ColumnName => Column.Name;

        public String PropertyName => ComputeReferencedName();


        public String ReferencedCLRName => Column.ForeignTable?.CLRTypeName;

        public String Comment => $" // {Column.TableName}.{ColumnName} (ForeignKey)";

        private String ComputeReferencedName()
        {
            var referencedTableName = Column.ForeignTable?.CLRTypeName
                       + ((Column.ForeignTable?.CLRTypeName == Column.TableCLRTypeName || Column.Table.ContainsTwoSameForeignReference) ? "_" + Column.FormattedName : "");
            return referencedTableName;
        }

      


    }
}
