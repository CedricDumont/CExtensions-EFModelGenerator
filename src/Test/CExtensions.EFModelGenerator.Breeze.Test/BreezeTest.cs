using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using Xunit;

namespace CExtensions.EFModelGenerator.Breeze.Test
{
    public class BreezeTest : BaseUnitTest
    {
        [Theory(DisplayName = "ShouldSerializeModel")]
        [InlineData("input", null, null, null)]

        public void ShouldSerializeModel(string folder, string configFile = null, string schemaFile = null, string expectedFile = null)
        {
            //1. Arrange
            string content = GetFileContent(configFile ?? "config.json", folder);
            string schema = GetFileContent(schemaFile ?? "schema.txt", folder);
           

            //Configure the test provider
            EFMGSettings[] settings = EFMGSettings.Build(content);

            //2. Act for each settings
            foreach (var setting in settings)
            {
                setting.Options.ProviderType = "Test.Helpers.TestSchemaProvider, Test.Helpers";
                setting.Options.ProviderTypeArguments = new string[] { schema };

                StringBuilder sb = new StringBuilder();
                using (TextWriter sw = new StringWriter(sb))
                {
                    Generator.Generate(setting, sw);
                }
                //write tests
                //var pathToExpected = Path.Combine("C:\\projects\\cextensions\\CExtensions-EFModelGenerator\\src\\Test\\CExtensions.EFModelGenerator.Breeze.Test", folder, setting.FilePath); ;
                //using (TextWriter writer = File.CreateText(pathToExpected))
                //{
                //    writer.Write(sb.ToString());
                //}
                //3. Assert
                string expectedOutput = GetFileContent(setting.FilePath, folder);
                string a = System.Text.RegularExpressions.Regex.Replace(sb.ToString(), @"\s+|\t|\n|\t\n\r\0\x0B", "");
                string b = System.Text.RegularExpressions.Regex.Replace(expectedOutput, @"\s+|\t|\n|\t\n\r\0\x0B", "");
                bool isTheSame = String.Compare(a, b) == 0;
                isTheSame.ShouldBe(true, $"Should be {Environment.NewLine}{b}{Environment.NewLine} but was {Environment.NewLine}{a}{Environment.NewLine}");

            }

            
        }
    }
}
