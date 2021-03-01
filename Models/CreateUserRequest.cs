using Newtonsoft.Json;


namespace ezconet_test.Models
{
    public class CreateUserRequest
    {
        
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthdate")]
        public string BirthDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; } = 1;

    }
}
