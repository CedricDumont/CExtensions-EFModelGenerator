using CExtensions.EFModelGenerator.Formatters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Model
{
    public class Table
    {
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
        internal FormatterCollection<Table> FormatterCollection { get; set; }

        [JsonIgnore]
        internal FormatterCollection<Table> DbSetFormatters { get; set; }

        [JsonIgnore]
        public IEnumerable<Column> PrimaryKeys
        {
            get
            {
                return from c in Columns where c.IsPrimaryKey == true select c;
            }
        }

        [JsonIgnore]
        public IEnumerable<ForeignKey> ForeignKeys
        {
            get
            {
                List<ForeignKey> result = new List<ForeignKey>();

                var list = from c in Columns where c.IsForeignKey == true select c;

                foreach (var col in list)
                {
                   
                    var key = new ForeignKey(col);

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
                                 group f by f.Column.ForeignTable?.Name into g
                                 where g.Count() > 1
                                 select new { Count = g.Count() };

                    return result.FirstOrDefault() != null;
                }
                return false;
            }
        }

        [JsonIgnore]
        public String CLRTypeName => FormatTableName() ;

        [JsonIgnore]
        internal string Info { get; set; }

        [JsonIgnore]
        public string CollectionName => FormatDbSetName();

        public override string ToString()
        {
            return CLRTypeName + $" [{this.Name}]";
        }

        public string FormatTableName()
        {
            var formatters = FormatterCollection.GetFormattersFor(this.Name);

            string newTableName = this.Name;

            foreach (var formatter in formatters)
            {
                if (formatter.IsApplicable(this, newTableName))
                {
                    newTableName = formatter.Apply(this, newTableName);

                    if (formatter.SkipOtherFormatters(this, newTableName))
                    {
                        break;
                    }
                }
            }

            //Todo change the Info thing with sthg else. basically it is used to check duplicates
            return newTableName + Info;
        }

        public string FormatDbSetName()
        {
            var formatters = DbSetFormatters.GetFormattersFor(this.Name);

            //add a default formatter for tables
            formatters.Insert(0,new UseClrTypeTableNameFormatter()); 
            formatters.Insert(1,new PluralizeTableNameFormatter());

            string newTableName = this.Name;

            foreach (var formatter in formatters)
            {
                if (formatter.IsApplicable(this, newTableName))
                {
                    newTableName = formatter.Apply(this, newTableName);

                    if (formatter.SkipOtherFormatters(this, newTableName))
                    {
                        break;
                    }
                }
            }

            return newTableName;
        }
    }
}
