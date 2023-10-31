using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public partial class LaunchDto
    {
        [JsonPropertyName("userId")]
        public long UserId { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
    }
}