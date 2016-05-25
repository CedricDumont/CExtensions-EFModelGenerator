using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CExtensions.EFModelGenerator.Test
{
    public class GeneratorUnitTest
    {
        [Fact]
        public void ShouldCreateRootFromConfigForFileWithoutRoot()
        {
            EFMGSettings settings = new EFMGSettings();
            settings.FilePath = "SomeFileName.cs";
            var configFilePath = @"c:\Temp\myConfig.json";

            Generator.ManageFilePath(configFilePath, settings);

            settings.FilePath.ShouldBe(@"c:\Temp\SomeFileName.cs");
        }

        [Fact]
        public void ShouldCreateFileNameFromConfigIfNull()
        {
            EFMGSettings settings = new EFMGSettings();
            var configFilePath = @"c:\Temp\myConfig.json";

            Generator.ManageFilePath(configFilePath, settings);

            settings.FilePath.ShouldBe(@"c:\Temp\myConfig.cs");
        }
    }
}
