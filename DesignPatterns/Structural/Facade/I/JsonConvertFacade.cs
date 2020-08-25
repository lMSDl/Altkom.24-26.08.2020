using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.I
{
    public class JsonConvertFacade
    {
        public static string Serialize<T>(T @object)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.Formatting = Formatting.Indented;
            settings.DateFormatString = "yy MMM dd";

            return JsonConvert.SerializeObject(@object, settings);
        }

        public static T Deserialize<T>(string @string)
        {
            return JsonConvert.DeserializeObject<T>(@string);
        }
    }
}
