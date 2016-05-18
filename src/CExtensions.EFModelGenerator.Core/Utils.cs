using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public sealed class Utils
    {
        public static String Pluralize(String s)
        {
            return s.Pluralize();
        }
    }
}
