using BlazorAPIClient.DataServices;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class Launches
    {
        [Inject]
        ITypicodeDataService? TypicodeDataService {get;set;}
        private LaunchDto[]? launches;
        protected override async Task OnInitializedAsync()
        {
            launches = await TypicodeDataService!.GetAllLaunches();
        }
    }
}