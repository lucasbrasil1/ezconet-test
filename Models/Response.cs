using Newtonsoft.Json;

namespace ezconet_test.Models
{
    public class Response
    {
        [JsonProperty("body")]
        public object Body { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }
    }
}