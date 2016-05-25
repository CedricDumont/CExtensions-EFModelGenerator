using CExtensions.EFModelGenerator.Interfaces;
using CExtensions.EFModelGenerator.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Formatters
{
    public abstract class AbstractTableNameFormatter : INameFormatter<Table>
    {
        public virtual bool IsApplicable(Table input, string currentName)
        {
            return true;
        }

        public abstract String Apply(Table input, string currentName);

        public virtual bool SkipOtherFormatters(Table input, string currentName)
        {
            return false;
        }
    }
    public class UpperFirstLetterTableNameFormatter : AbstractTableNameFormatter
    {
        public override String Apply(Table col, string currentName)
        {
            var firstLetterUpper = currentName.Substring(0, 1).ToUpper();
            return firstLetterUpper + currentName.Remove(0, 1);

        }
    }

    public class UseClrTypeTableNameFormatter : AbstractTableNameFormatter
    {
        public override String Apply(Table tbl, string currentName)
        {
            return tbl.CLRTypeName;
        }
    }

    public class PluralizeTableNameFormatter : AbstractTableNameFormatter
    {
        public override String Apply(Table tbl, string currentName)
        {
            return Utils.Pluralize(currentName);
        }
    }

    public class TitleCaseTableNameFormatter : AbstractTableNameFormatter
    {
        public override String Apply(Table col, string currentName)
        {
            var yourString = currentName;
            yourString = yourString.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        }
    }

    public class RemoveTillFirstUnderscoreTableNameFormatter : AbstractTableNameFormatter
    {
        public override String Apply(Table tbl, string currentName)
        {
            var index = currentName.ToLower().IndexOf("_");

            if (index > 0)
            {
                var colName = currentName.Remove(0, index + 1);

                return colName;
            }
            else
            {
                return tbl.Name;
            }
        }
    }

}
