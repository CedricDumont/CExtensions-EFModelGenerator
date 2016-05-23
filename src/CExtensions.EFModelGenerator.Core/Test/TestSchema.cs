using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core.Test
{
    public class TestSchema : Schema
    {
        public TestSchema() : base("MockSchema", new GenerationOptions())
        {
            //create a mock schema to use for test
            //this.Tables.Add(new Table())
        }
    }
}
