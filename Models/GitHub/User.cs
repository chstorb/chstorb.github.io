using System.Text.Json.Serialization;

namespace BlazorWebAssemblyApp.Models.GitHub;

public class User
{
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }
}
