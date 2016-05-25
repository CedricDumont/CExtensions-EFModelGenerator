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
    public abstract class AbstractColumnNameFormatter : INameFormatter<Column>
    {
        public virtual bool IsApplicable(Column input, string currentName)
        {
            return true;
        }

        public abstract String Apply(Column input, string currentName);

        public virtual bool SkipOtherFormatters(Column input, string currentName)
        {
            return false;
        }
    }

    public class UpperFirstLetterNameFormatter : AbstractColumnNameFormatter
    {
        public override String Apply(Column col, string currentName)
        {
            var firstLetterUpper = currentName.Substring(0, 1).ToUpper();
            return firstLetterUpper + currentName.Remove(0, 1);

        }
    }

    public class TitleCaseNameFormatter : AbstractColumnNameFormatter
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

    public class RemoveTillFirstUnderscoreNameFormatter : AbstractColumnNameFormatter
    {
        public RemoveTillFirstUnderscoreNameFormatter()
        {

        }

        public RemoveTillFirstUnderscoreNameFormatter(IList<string> regExpExludeList)
        {
            ExclusionList = regExpExludeList;
        }

        public IList<string> ExclusionList { get; set; }

        public override bool IsApplicable(Column col, string currentName)
        {
            if (ExclusionList == null) return true;

            foreach (var pattern in ExclusionList)
            {
                Regex expression = new Regex(pattern.ToString());

                if(expression.IsMatch(col.Name))
                {
                    return false;
                }
            }

            return true;
        }

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

    public class SafeIdColumnNameFormatter : AbstractColumnNameFormatter
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

    public class IDColumnFormatter : AbstractColumnNameFormatter
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
