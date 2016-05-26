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

            GenerationOptions defaultOptions = GetDefaultOptions(result);

            JArray settingsArray = result["Settings"] as JArray;

            if (settingsArray != null)
            {
                foreach (var setting in settingsArray)
                {
                    var obj = (EFMGSettings)setting.ToObject(typeof(EFMGSettings));
                    obj.Options.MergeWith(defaultOptions);
                    settings.Add(obj);
                }
            }
            else
            {
                var obj = (EFMGSettings)result.ToObject(typeof(EFMGSettings));
                obj.Options.MergeWith(defaultOptions);
                settings.Add(obj);
            }

            return settings.ToArray();
        }

       

        private static GenerationOptions GetDefaultOptions(JObject result)
        {
            JProperty property = result.First as JProperty;

            GenerationOptions defaults = null;

            if (property != null && property.Name == "DefaultOptions")
            {
                defaults = (GenerationOptions)result["DefaultOptions"].ToObject(typeof(GenerationOptions));
            }

            return defaults;
        }
    }
}
