using CExtensions.EFModelGenerator.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class Table
    {
        private Func<String, String> _NameFormatter = str =>
        {
            var yourString = str.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        };

        internal Table()
        {
            Columns = new List<Column>();
        }


        internal void Init(String name)
        {
            Name = name;
        }

        public String Name { get; set; }

        public IList<Column> Columns { get; set; }

        [JsonIgnore]
        public IEnumerable<Column> PrimaryKeys
        {
            get
            {
                return from c in Columns where c.IsPrimaryKey == true select c;
            }
        }

        [JsonIgnore]
        public IEnumerable<IForeignKey> ForeignKeys
        {
            get
            {
                List<IForeignKey> result = new List<IForeignKey>();

                var list = from c in Columns where c.IsForeignKey == true select c;

                foreach (var col in list)
                {
                    var key = new ForeignKey(this, col);

                    result.Add(key);
                }

                return result;
            }
        }



        /// <summary>
        /// All columns of the table except Foreign and Primary keys
        /// </summary>
        [JsonIgnore]
        public IEnumerable<Column> DataColumns
        {
            get
            {
                return from c in Columns where c.IsForeignKey != true  && c.IsPrimaryKey != true select c;
            }
        }

        [JsonIgnore]
        public bool ContainsTwoSameForeignReference
        {
            get{
                if (ForeignKeys.Count() > 0)
                {
                    var result = from f in ForeignKeys
                                 group f by f.Column.ForeignTableName into g
                                 where g.Count() > 1
                                 select new { Count = g.Count() };

                    return result.FirstOrDefault() != null;
                }
                return false;
            }
        }

        [JsonIgnore]
        public String CLRTypeName => _NameFormatter(Name) + Info;

        [JsonIgnore]
        internal string Info { get; set; }

        [JsonIgnore]
        public string CollectionName => Utils.Pluralize(CLRTypeName);

        public override string ToString()
        {
            return CLRTypeName + $" [{this.Name}]";
        }
    }
}
