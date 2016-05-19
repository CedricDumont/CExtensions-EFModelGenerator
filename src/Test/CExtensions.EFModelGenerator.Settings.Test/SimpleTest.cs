using CExtensions.EFModelGenerator.Common;
using Shouldly;
using System;
using System.Collections.Generic;
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

            obj.Options.ProviderType.ShouldBe("SomeType");
        }
    }
}
