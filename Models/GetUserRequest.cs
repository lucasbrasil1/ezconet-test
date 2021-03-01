using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ezconet_test.Controllers
{
    public class GetUserRequest
    {
        [JsonProperty("name"), JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("active"), JsonPropertyName("active")]
        public string Active { get; set; }

    }
}