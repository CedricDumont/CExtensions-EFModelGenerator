using CExtensions.EFModelGenerator.Formatters;
using CExtensions.EFModelGenerator.Model;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CExtensions.EFModelGenerator.Test
{
    public class NameFormattersTest
    {
        [Theory (DisplayName ="RemoveTillFirstUnderscoreNameFormatter_RegexTest")]
        [InlineData("MY_ID", "(_ID)", false)] // has_ID in it's name
        [InlineData("MY_OTHERCOL", "(_ID)", true)]// has_ID in it's name
        [InlineData("Cont$ain$", "[$]", false)] // has the $ sign char (one or more times)
        [InlineData("Cont$$ain", "[$]", false)] // has the $ sign char (one or more times)
        [InlineData("nodollars", "[$]", true)] // has the $ sign char (one or more times)
        [InlineData("FULL_NAME", "FULL_NAME", false)] // a full match
        [InlineData("BACKUP_AT_START", "(?i)(^backup)", false)] //start with backup insensitive case
        [InlineData("backUP_AT_START", "(?i)(^backup)", false)]//start with backup insensitive case
        [InlineData("SOMECOL_Z", "Z$", false)]//ends with Z (case sensitive)
        public void RemoveTillFirstUnderscoreNameFormatter_RegexTest(string colName, string regex, bool isApplicableReturnResult)
        {
            //test tool : https://regex101.com/

            ColumnMetadata metadata = new ColumnMetadata()
            {
                Name = colName
            };

            Column testCol = new Column("TABLENAME", metadata);

            RemoveTillFirstUnderscoreNameFormatter formatter = 
                new RemoveTillFirstUnderscoreNameFormatter(new List<string>() { regex });

            bool result = formatter.IsApplicable(testCol, testCol.Name);

            result.ShouldBe(isApplicableReturnResult);

        }
    }
}
