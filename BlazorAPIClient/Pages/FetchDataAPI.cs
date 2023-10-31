using System.Net.Http.Json;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class FetchDataAPI
    {
        [Inject]
        private HttpClient? Http { get; set; }
        private LaunchDto[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http!.GetFromJsonAsync<LaunchDto[]>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}