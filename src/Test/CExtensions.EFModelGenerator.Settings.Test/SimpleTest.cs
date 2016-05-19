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

        [Fact]
        public void ShouldSerializeSettings()
        {
            string content = GetFileContent("test-1");

            var obj = EFMGSettings.Build(content);

            obj.Options.ProviderType.ShouldBe("CExtensions.EFModelGenerator.SqlServer.SqlDataProvider, CExtensions.EFModelGenerator.SqlServer");

            StringBuilder sb = new StringBuilder();

            using (StringWriter sw = new StringWriter(sb))
            {

                Generator generator = new Generator(obj.Options);
                generator.Generate(sw);

            }

            sb.ShouldNotBeNull();


        }
    }
}
