using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class ApplicationInfo
    {
        public static bool TestMode = false;

        public string _generationInfo;

        public string GenerationInfo
        {
            get
            {
                if (_generationInfo == null)
                {
                    StringBuilder sb = new StringBuilder();

                    var assemblyName = Assembly.GetExecutingAssembly().GetName().FullName;
                    if (!TestMode)
                    {
                        sb.AppendLine($"// This code was generated with {assemblyName} on {DateTime.Now}");
                    }
                    sb.AppendLine(@"// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator");
                    sb.AppendLine($"// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)");

                    _generationInfo = sb.ToString();
                }

                return _generationInfo;


            }

        }
    }
}
