using CExtensions.EFModelGenerator.Formatters;
using CExtensions.EFModelGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Test.CustomNameFormatters
{
    public class AllLowerCaseColumnNameFormatter : AbstractColumnNameFormatter
    {
        public override String Apply(Column input, string currentName)
        {
            return currentName?.ToLower();
        }
    }
}
