using System.Text.Json.Serialization;
using System.Text.Json;

namespace DevPortfolioServer.Utility
{
    public class JsonHelper
    {
        private JsonHelper()
        {
        }
        public static string FunJsonSerializer(object obj)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            var jsonString = JsonSerializer.Serialize(obj, options);
            return jsonString;
        }
        public static object FunJsonDeserialize(string jsonString)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            var obj = JsonSerializer.Deserialize<object>(jsonString, options);
            return obj;
        }
    }
}
