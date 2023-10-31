using System.Text;
using System.Text.Json;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class GraphQLSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public GraphQLSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LaunchX[]?> GetAllLaunches()
        {
            var queryOject = new {
                  query = @"{ launches{ id	upcoming mission_name	launch_date_local }}",
                  variable = new {}
            };

            var launchQuery = new StringContent(
                JsonSerializer.Serialize(queryOject),
                Encoding.UTF8,
                "application/json");
            var response = await _httpClient.PostAsync("https://spacex-production.up.railway.app/",launchQuery);
            if(response.IsSuccessStatusCode){
                var gqlData = await JsonSerializer.DeserializeAsync<GqlData>
                                     (await response.Content.ReadAsStreamAsync());
                return gqlData!.Data!.Launches;
            }
            return null;
        }
    }
}