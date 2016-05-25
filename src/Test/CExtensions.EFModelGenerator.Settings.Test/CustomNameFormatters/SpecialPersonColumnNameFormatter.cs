﻿using CExtensions.EFModelGenerator.Formatters;
using CExtensions.EFModelGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Settings.Test.CustomNameFormatters
{
    public class SpecialPersonColumnNameFormatter : AbstractColumnNameFormatter
    {
        public override bool IsApplicable(Column col, string currentName)
        {
            if(col.Table.Name == "Person")
            {
                if (col.Name == "LAST_NAME")
                {
                    return true;
                }
            }

            return false;
        }

        public override String Apply(Column col, string currentName)
        {
            if (col.Name == "LAST_NAME")
            {
                currentName = "FamilyName";
            }

            return currentName;
        }

        public override bool SkipOtherFormatters(Column col, string currentName)
        {
            return true;
        }
    }
}
