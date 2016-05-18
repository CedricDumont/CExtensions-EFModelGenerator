using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Table : ITable
    {
        private Func<string, string> _NameFormatter;

        internal Table(ISchema schema, String name, Func<string, string> NameFormatter)
        {
            _NameFormatter = NameFormatter;
            Columns = new List<IColumn>();
            Schema = schema;
            Name = name;
        }

        public ISchema Schema { get; private set; }

        public String Name { get; private set; }

        public IList<IColumn> Columns { get; set; }

        public IEnumerable<IColumn> PrimaryKeys
        {
            get
            {
                return from c in Columns where c.IsPrimaryKey == true select c;
            }
        }

        public IEnumerable<IForeignKey> ForeignKeys
        {
            get
            {
                List<IForeignKey> result = new List<IForeignKey>();

                var list = from c in Columns where c.IsForeignKey == true select c;

                foreach (var col in list)
                {
                    var key = new ForeignKey(col);

                    result.Add(key);
                }

                return result;
            }
        }

        public IEnumerable<IInverseProperty> InverseProperties
        {
            get
            {
                List<InverseProperty> result = new List<InverseProperty>();

                if (this.RelatedTables.Count() > 0)
                {
                    int counter = 1;
                    List<String> tracker = new List<string>();
                    foreach (var reverseNavigation in this.RelatedTables)
                    {
                        var propertyName = reverseNavigation.Table.CLRTypeName + ((reverseNavigation.Table.CLRTypeName == this.CLRTypeName) ? $"_{counter++}" : "");
                        if (tracker.Contains(propertyName))
                        {
                            propertyName += counter++;
                        }
                        tracker.Add(propertyName);

                        result.Add(new InverseProperty() {
                            PropertyName = propertyName,
                            ReversePropertyName = reverseNavigation.FormattedName,
                            ReverseCLRType = reverseNavigation.Table.CLRTypeName
                        });
                    }

                }

                return result;
            }
        }

        /// <summary>
        /// All columns of the table except Foreign and Primary keys
        /// </summary>
        public IEnumerable<IColumn> DataColumns
        {
            get
            {
                return from c in Columns where c.IsForeignKey != true  && c.IsPrimaryKey != true select c;
            }
        }

        public bool ContainsTwoSameForeignReference
        {
            get{
                if (ForeignKeys.Count() > 0)
                {
                    var result = from f in ForeignKeys
                                 group f by f.Column.ForeignTable?.Name into g
                                 where g.Count() > 1
                                 select new { Count = g.Count() };

                    return result.FirstOrDefault() != null;
                }
                return false;
            }
        }

        public List<IColumn> RelatedTables{
            get{
                var tables = from c in this.Schema.AllColumns
                             where c.ForeignTable?.Name == this.Name
                             select c;

                return tables.ToList();
            }
        } 



        public String CLRTypeName => _NameFormatter(Name) + Info;

        internal string Info { get; set; }

        public string CollectionName => Utils.Pluralize(CLRTypeName);

        public override string ToString()
        {
            return CLRTypeName + $" [{this.Name}]";
        }
    }
}
