using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Schema : ISchema
    {
        internal Schema(string name, GenerationOptions options)
        {
            this.Name = name;
            this.Tables = new List<ITable>();
            GeneratorOptions = options;
        }

        public String Name { get; set; }

        public List<ITable> Tables { get; set; }

        public List<IColumn> AllColumns
        {
            get
            {
                List<IColumn> mergedColumns = new List<IColumn>();
                Tables.ForEach(t =>
                {
                    mergedColumns.AddRange(t.Columns);
                });
                return mergedColumns;
            }
        }


        public GenerationOptions GeneratorOptions { get; set; }

    }
}
