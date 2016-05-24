using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using Xunit;

namespace CExtensions.EFModelGenerator.Settings.Test
{
    public class SimpleTest : BaseUnitTest
    {
        [Theory(DisplayName = "ShouldSerializeModel")]
        [InlineData("input\\skipTable", null, null, null)]
        [InlineData("input\\sameNameAsEnclosingType", null, null, null)]
        [InlineData("input\\nameFormatters", null, null, null)]
        [InlineData("input\\customNameFormatters", null, null, null)]
        [InlineData("input\\withRelations", null, null, null)]
        [InlineData("input\\MultipleRelationsWithFormatters", null, null, null)]
        [InlineData("input\\foreignKeysToSelf", null, null, null)]
        [InlineData("input\\foreignKeysToSelfWithFormatters", null, null, null)]
        
        public void ShouldSerializeModel(string folder, string configFile =null, string schemaFile = null, string expectedFile = null)
        {
            //1. Arrange
            string content = GetFileContent(configFile ?? "config.json", folder);
            string schema = GetFileContent(schemaFile ?? "schema.txt", folder);
            string expectedOutput = GetFileContent(expectedFile ?? "expected.cs", folder);

            //Configure the test provider
            var settings = EFMGSettings.Build(content);
            settings.Options.ProviderType = "Test.Helpers.TestSchemaProvider, Test.Helpers";
            settings.Options.ProviderTypeArguments = new string[] { schema };

            //2. Act
            StringBuilder sb = new StringBuilder();

            using (TextWriter sw = new StringWriter(sb))
            {
                Generator.Generate(settings, sw);
            }

            //3. Assert
            string a = System.Text.RegularExpressions.Regex.Replace(sb.ToString(), @"\s", "");
            string b = System.Text.RegularExpressions.Regex.Replace(expectedOutput, @"\s", "");
            bool isTheSame = String.Compare(a, b) == 0;
            isTheSame.ShouldBe(true, $"Should be {Environment.NewLine}{b}{Environment.NewLine} but was {Environment.NewLine}{a}{Environment.NewLine}");
        }
    }
}
