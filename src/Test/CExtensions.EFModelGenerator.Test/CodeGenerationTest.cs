using CExtensions.EFModelGenerator;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using Xunit;

namespace CExtensions.EFModelGenerator.Test
{
    public class CodeGenerationTest : BaseUnitTest
    {
        [Theory(DisplayName = "ShouldSerializeModel")]
        [InlineData("input\\ForeignKeys\\ForeignKeysToSelf", null, null, null)]
        [InlineData("input\\ForeignKeys\\ForeignKeysToSelfWithFormatters", null, null, null)]
        [InlineData("input\\Formatters\\CoreColumnNameFormatters", null, null, null)]
        [InlineData("input\\Formatters\\CustomColumnNameFormatters", null, null, null)]
        [InlineData("input\\Formatters\\RemoveTillFirstUnderscoreNameFormatterWithExclusions", null, null, null)]
        [InlineData("input\\Misc\\ErrorDisplay", null, null, "expected.txt")]
        [InlineData("input\\Misc\\IgnoreTableRegex", null, null, null)]
        [InlineData("input\\Misc\\PropertyWithSameNameAsEnclosingType", null, null, null)]
        [InlineData("input\\Relations\\MultipleRelationsWithFormatters", null, null, null)]
        [InlineData("input\\Relations\\SimpleRelation", null, null, null)]
        [InlineData("input\\GenerationWithDbContext", null, null, null)]
        [InlineData("input\\Serializers\\ListColumnsCustomSerializer", null, null, "expected.txt")]
        [InlineData("input\\Serializers\\CoreSerializerOnlyDbContext", null, null, "expected.txt")]
        [InlineData("input\\Serializers\\CoreSerializerOnlyModel", null, null, "expected.cs")]
        public void ShouldSerializeModel(string folder, string configFile =null, string schemaFile = null, string expectedFile = null)
        {
            ApplicationInfo.TestMode = true;
            //1. Arrange
            string content = GetFileContent(configFile ?? "config.json", folder);
            string schema = GetFileContent(schemaFile ?? "schema.txt", folder);
            string expectedOutput = GetFileContent(expectedFile ?? "expected.cs", folder);

            //Configure the test provider
            var settings = EFMGSettings.Build(content);
            settings[0].Options.ProviderType = "Test.Helpers.TestSchemaProvider, Test.Helpers";
            settings[0].Options.ProviderTypeArguments = new string[] { schema };

            //2. Act
            StringBuilder sb = new StringBuilder();

            using (TextWriter sw = new StringWriter(sb))
            {
                Generator.Generate(settings[0], sw);
            }

            //writeToFile
            //var pathToExpected = Path.Combine("C:\\projects\\cextensions\\CExtensions-EFModelGenerator\\src\\Test\\CExtensions.EFModelGenerator.Test", folder, expectedFile ?? "expected.cs"); ;
            //using (TextWriter writer = File.CreateText(pathToExpected))
            //{
            //    writer.Write(sb.ToString());
            //}
            //Assert.False(true);

            ////3. Assert
            string a = System.Text.RegularExpressions.Regex.Replace(sb.ToString(), @"\s+|\t|\n|\t\n\r\0\x0B", "");
            string b = System.Text.RegularExpressions.Regex.Replace(expectedOutput, @"\s+|\t|\n|\t\n\r\0\x0B", "");
            bool isTheSame = String.Compare(a, b) == 0;
            isTheSame.ShouldBe(true, $"Should be {Environment.NewLine}{b}{Environment.NewLine} but was {Environment.NewLine}{a}{Environment.NewLine}");
        }
    }
}
