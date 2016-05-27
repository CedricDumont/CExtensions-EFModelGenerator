using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CExtensions.EFModelGenerator.Test
{
    public class GenerationOptionsTest
    {
        [Fact]
        public void ShouldMergeOptions()
        {
            GenerationOptions options = new GenerationOptions();
            options.ElementToGenerate = "All";
            GenerationOptions tomergeOptions = new GenerationOptions();
            options.ElementToGenerate = "Model";
            options.MergeWith(tomergeOptions);

            options.ElementToGenerate.ShouldBe("Model");
        }
    }
}
