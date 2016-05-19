using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class ColumnConfiguration
    {
        Dictionary<string, List<INameFormatter<IColumn>>> _tableColumnFormatters = new Dictionary<string, List<INameFormatter<IColumn>>>();

        List<INameFormatter<IColumn>> _generalFormattersList = new List<INameFormatter<IColumn>>();

        public IList<INameFormatter<IColumn>> GetFormattersFor(string tableName)
        {
            List<INameFormatter<IColumn>> mergedList = new List<INameFormatter<IColumn>>();
            mergedList.AddRange(_generalFormattersList);

            if (_tableColumnFormatters.ContainsKey(tableName))
            {
                mergedList.InsertRange(0, _tableColumnFormatters[tableName]);
            }

            return mergedList;
        }

        public void AddFormatter(INameFormatter<IColumn> formatter)
        {
            _generalFormattersList.Add(formatter);
        }

        public void AddFormatter(String tableName, INameFormatter<IColumn> formatter)
        {
            if (!_tableColumnFormatters.ContainsKey(tableName))
            {
                _tableColumnFormatters[tableName] = new List<INameFormatter<IColumn>>();

            }
            _tableColumnFormatters[tableName].Add(formatter);
        }
    }
}
