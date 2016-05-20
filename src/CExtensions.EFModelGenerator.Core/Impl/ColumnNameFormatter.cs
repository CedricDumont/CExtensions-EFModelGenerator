using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public class ColumnNameFormatter : INameFormatter<Column>
    {
        public virtual bool IsApplicable(Column input)
        {
            return true;
        }

        public virtual String Apply(Column input)
        {
            return input.Name;
        }
    }


    public class RemoveUnderscoreNameFormatter : ColumnNameFormatter
    {
        public override String Apply(Column col)
        {
            var yourString = col.Name;
            yourString = yourString.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        }
    }

    public class KeepIdColumnNameFormatter : ColumnNameFormatter
    {
        public override bool IsApplicable(Column input)
        {
            if (!input.IsPrimaryKey)
            {
                Regex regular = new Regex(@"\w*_ID\b");

                if (regular.Matches(input.Name).Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override String Apply(Column col)
        {
            var yourString = col.Name;
            yourString = yourString.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            yourString = info.ToTitleCase(yourString).Replace(" ", string.Empty);
            return yourString;
        }
    }

    public class IDColumnFormatter : ColumnNameFormatter
    {
        public override bool IsApplicable(Column input)
        {
            if (input.IsPrimaryKey)
            {
                return true;
            }
            return false;
        }

        public override String Apply(Column col)
        {
            return "ID";
        }
    }



}
