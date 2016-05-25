using CExtensions.EFModelGenerator;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class EFMGSettings
    {
        public String FilePath { get; set; }

        public GenerationOptions Options { get; set; }


        public static EFMGSettings[] Build(String s)
        {
            List<EFMGSettings> settings = new List<EFMGSettings>();

            JObject result = (JObject)JsonConvert.DeserializeObject(s);

            JProperty property = result.First as JProperty;

            if (property != null && property.Name == "Settings")
            {
                foreach (var setting in result["Settings"])
                {
                    var obj = (EFMGSettings)setting.ToObject(typeof(EFMGSettings));
                    settings.Add(obj);
                }
            }
            else
            {
                var obj = (EFMGSettings)result.ToObject(typeof(EFMGSettings));
                settings.Add(obj);
            }

            return settings.ToArray();
        }
    }
}
