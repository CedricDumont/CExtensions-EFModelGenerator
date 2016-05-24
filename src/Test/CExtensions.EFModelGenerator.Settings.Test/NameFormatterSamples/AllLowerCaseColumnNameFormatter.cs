using CExtensions.EFModelGenerator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Settings.Test.NameFormatterSamples
{
    public class AllLowerCaseColumnNameFormatter : ColumnNameFormatter
    {
        public override String Apply(Column input, string currentName)
        {
            return currentName?.ToLower();
        }
    }
}
