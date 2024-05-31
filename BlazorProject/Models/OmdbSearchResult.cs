using System.Text.Json.Serialization;

namespace OmdbBlazerApp.BlazorProject.Models
{
    public class OmdbSearchResult
    {
        [JsonPropertyName("Search")]
        public List<Movie>? Movies { get; set; }

        [JsonPropertyName("totalResults")]
        public string? TotalResults { get; set; }

        [JsonPropertyName("Response")]
        public string? Response { get; set; }
		
        [JsonPropertyName("Error")]
		public string? Error { get; set; }

    }
}
