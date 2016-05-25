using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class FormatterCollection<T> where T : class
    {
        Dictionary<string, List<INameFormatter<T>>> _tableColumnFormatters = new Dictionary<string, List<INameFormatter<T>>>();

        List<INameFormatter<T>> _generalFormattersList = new List<INameFormatter<T>>();

        public IList<INameFormatter<T>> GetFormattersFor(string tableName)
        {
            List<INameFormatter<T>> mergedList = new List<INameFormatter<T>>();
            mergedList.AddRange(_generalFormattersList);

            if (_tableColumnFormatters.ContainsKey(tableName))
            {
                mergedList.InsertRange(0, _tableColumnFormatters[tableName]);
            }

            return mergedList;
        }

        public void AddFormatter(INameFormatter<T> formatter)
        {
            _generalFormattersList.Add(formatter);
        }

        public void AddFormatter(String tableName, INameFormatter<T> formatter)
        {
            if (!_tableColumnFormatters.ContainsKey(tableName))
            {
                _tableColumnFormatters[tableName] = new List<INameFormatter<T>>();

            }
            _tableColumnFormatters[tableName].Add(formatter);
        }
    }
}
