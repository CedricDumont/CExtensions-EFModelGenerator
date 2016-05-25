using CExtensions.EFModelGenerator;
using CExtensions.EFModelGenerator.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Serializers
{
    public abstract class AbstractSerializer 
    {
        public string CallSerializeWith(string serializedSchema)
        {
            Schema schema = JsonConvert.DeserializeObject<Schema>(serializedSchema);

            schema.Init();

            return Serialize(schema);
        }

        public abstract string Serialize(Schema schema);
    }
}
