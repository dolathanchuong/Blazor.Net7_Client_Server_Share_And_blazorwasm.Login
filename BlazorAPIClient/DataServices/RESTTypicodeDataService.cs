using System.Net.Http.Json;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class RESTTypicodeDataService : ITypicodeDataService
    {
        private readonly HttpClient _httpClient;

        public RESTTypicodeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LaunchDto[]?> GetAllLaunches()
        {
            return await _httpClient.GetFromJsonAsync<LaunchDto[]>("todos");
        }
    }
}