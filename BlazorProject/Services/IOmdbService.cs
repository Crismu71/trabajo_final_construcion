using OmdbBlazerApp.BlazorProject.Models;

namespace OmdbBlazerApp.BlazorProject.Services
{
    public interface IOmdbService
    {
        public Task<OmdbSearchResult> GetOmdbSearchAsync(string search, int page);
    }
}
