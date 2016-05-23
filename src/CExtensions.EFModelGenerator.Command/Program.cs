using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CExtensions_EFModelGenerator.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator.Generate(@"C:\projects\cextensions\CExtensions-EFModelGenerator\src\CExtensions.EFModelGenerator.Command\Models.json");
        }
    }
}
