using BlazorAPIClient.DataServices;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class Launch
    {
        [Inject]
        ISpaceXDataService? GetSpaceXDataService {get;set;}
        private LaunchX[]? launch;
        protected override async Task OnInitializedAsync()
        {
            launch = await GetSpaceXDataService!.GetAllLaunches();
        }
    }
}