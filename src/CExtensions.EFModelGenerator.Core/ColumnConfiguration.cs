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
        Dictionary<string, List<INameFormatter<Column>>> _tableColumnFormatters = new Dictionary<string, List<INameFormatter<Column>>>();

        List<INameFormatter<Column>> _generalFormattersList = new List<INameFormatter<Column>>();

        public IList<INameFormatter<Column>> GetFormattersFor(string tableName)
        {
            List<INameFormatter<Column>> mergedList = new List<INameFormatter<Column>>();
            mergedList.AddRange(_generalFormattersList);

            if (_tableColumnFormatters.ContainsKey(tableName))
            {
                mergedList.InsertRange(0, _tableColumnFormatters[tableName]);
            }

            return mergedList;
        }

        public void AddFormatter(INameFormatter<Column> formatter)
        {
            _generalFormattersList.Add(formatter);
        }

        public void AddFormatter(String tableName, INameFormatter<Column> formatter)
        {
            if (!_tableColumnFormatters.ContainsKey(tableName))
            {
                _tableColumnFormatters[tableName] = new List<INameFormatter<Column>>();

            }
            _tableColumnFormatters[tableName].Add(formatter);
        }
    }
}
