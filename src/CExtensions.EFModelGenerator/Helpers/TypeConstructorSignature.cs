using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Helpers
{
    public class TypeConstructorSignature
    {
        public String Name { get; set; }

        public Object[] Params { get; set; }

        [JsonIgnore]
        public Object[] ParamsForConstructor
        {
            get
            {
                if(Params == null)
                {
                    return null;
                }

                List<Object> items = new List<object>();

                foreach (var item in Params)
                {
                    object transformedItem = item;
                    if(item is Newtonsoft.Json.Linq.JArray)
                    {
                        transformedItem = ((Newtonsoft.Json.Linq.JArray)item).ToObject<string[]>();
                    }

                    items.Add(transformedItem);
                }

                return items.ToArray();
            }
        }
    }
}
