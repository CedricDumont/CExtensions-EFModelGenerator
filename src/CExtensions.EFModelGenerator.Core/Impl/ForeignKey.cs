using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class ForeignKey : IForeignKey
    {
        public ForeignKey(IColumn column)
        {
            this.Column = column;
        }

        public IColumn Column { get; set; }

        public String ColumnCLRType => Column.CLRType;

        public String ForeignKeyName => Column.FormattedName;

        public String ColumnName => Column.Name;

        public String PropertyName => ComputeReferencedName();

        public String ReferencedCLRName => Column.ForeignTable.CLRTypeName;

        public String Comment => $" // {Column.Table.Name}.{ColumnName} (ForeignKey)";



        private String ComputeReferencedName()
        {
            var referencedTableName = Column.ForeignTable.CLRTypeName
                       + ((Column.ForeignTable.CLRTypeName == Column.Table.CLRTypeName || Column.Table.ContainsTwoSameForeignReference) ? "_" + Column.FormattedName : "");
            return referencedTableName;
        }


    }
}
