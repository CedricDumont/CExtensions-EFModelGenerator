using CExtensions.EFModelGenerator.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Common
{
    public class EFMGSettings
    {

        public String FilePath { get; set; }

        public GenerationOptions Options { get; set; }


        public static EFMGSettings Build(String s)
        {
            var result = JsonConvert.DeserializeObject<EFMGSettings>(s);

            return result;
        }
    }
}
