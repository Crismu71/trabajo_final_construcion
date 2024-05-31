using OmdbBlazerApp.BlazorProject.Models;

namespace OmdbBlazerApp.BlazorProject.Services
{
    public class OmdbService : IOmdbService
    {
        private readonly HttpClient _httpClient;

        public OmdbService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<OmdbSearchResult> GetOmdbSearchAsync(string search, int page)
        {
            if (string.IsNullOrWhiteSpace(search))
            {
                search = " ";
            }
            var parseSearch = search.Replace(" ", "%20");
            var uriQuery = $"?s={parseSearch}&page={page}&apikey=219d12bd";
            var result = await _httpClient.GetFromJsonAsync<OmdbSearchResult>(uriQuery);

            if (result != null && result.Response == "True") {
                return result;
            }
            return new OmdbSearchResult { Movies = [], TotalResults = "0", Response = "False" };
        }
    }
}
