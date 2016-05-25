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
    public class ColumnNameFormatter : INameFormatter<Column>
    {
        public virtual bool IsApplicable(Column input, string currentName)
        {
            return true;
        }

        public virtual String Apply(Column input, string currentName)
        {
            return currentName;
        }

        public virtual bool SkipOtherFormatters(Column input, string currentName)
        {
            return false;
        }
    }

    public class UpperFirstLetterNameFormatter : ColumnNameFormatter
    {
        public override String Apply(Column col, string currentName)
        {
            var firstLetterUpper = currentName.Substring(0, 1).ToUpper();
            return firstLetterUpper + currentName.Remove(0, 1);

        }
    }

    public class TitleCaseNameFormatter : ColumnNameFormatter
    {
        public override String Apply(Column col, string currentName)
        {
            var yourString = currentName;
            yourString = yourString.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        }
    }

    public class RemoveTillFirstUnderscoreNameFormatter : ColumnNameFormatter
    {
        public override String Apply(Column col, string currentName)
        {
            var index = currentName.ToLower().IndexOf("_");

            if (index > 0)
            {
                var colName = currentName.Remove(0, index + 1);

                return colName;
            }
            else
            {
                return col.Name;
            }
        }
    }

    public class SafeIdColumnNameFormatter : ColumnNameFormatter
    {
        public override bool IsApplicable(Column col, string currentName)
        {
            if (!col.IsPrimaryKey)
            {
                Regex regular = new Regex(@"\w*_ID\b", RegexOptions.IgnoreCase);

                if (regular.Matches(col.Name).Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override String Apply(Column col, string currentName)
        {
            var yourString = currentName;
            yourString = yourString.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        }

        public override bool SkipOtherFormatters(Column input, string currentName)
        {
            return true;
        }
    }

    public class IDColumnFormatter : ColumnNameFormatter
    {
        public override bool IsApplicable(Column input, string currentName)
        {
            if (input.IsPrimaryKey && input.Table.PrimaryKeys.Count() == 1 )
            {
                return true;
            }
            return false;
        }

        public override String Apply(Column col, string currentName)
        {
            return "ID";
        }

        public override  bool SkipOtherFormatters(Column input, string currentName)
        {
            return true;
        }
    }



}
