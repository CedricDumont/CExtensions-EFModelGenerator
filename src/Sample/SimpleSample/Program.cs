using CExtensions.EFModelGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToYourJson = @"C:\projects\cextensions\CExtensions-EFModelGenerator\src\Sample\SimpleSample\Models.json";
            
            Generator.Generate(pathToYourJson);
        }
    }
}
