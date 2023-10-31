using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
public partial class LaunchX
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("upcoming")]
        public bool Upcoming { get; set; }

        [JsonPropertyName("mission_name")]
        public string? MissionName { get; set; }

        [JsonPropertyName("launch_date_local")]
        public DateTimeOffset LaunchDateLocal { get; set; }
    }
}