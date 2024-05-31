using System.Text.Json.Serialization;

namespace OmdbBlazerApp.BlazorProject.Models
{
    public class Movie
    {
        [JsonPropertyName("imdbId")]
        public required string ImdbId { get; set; }

        [JsonPropertyName("Title")]
        public required string Title { get; set; }

        [JsonPropertyName("Year")]
        public string? Year { get; set; }

        [JsonPropertyName("Type")]
        public string? Type { get; set; }

        [JsonPropertyName("Poster")]
        public string? Poster { get; set; }
    }
}
