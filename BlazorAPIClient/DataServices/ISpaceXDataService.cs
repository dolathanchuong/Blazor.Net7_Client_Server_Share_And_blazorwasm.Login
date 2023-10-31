using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public interface ISpaceXDataService
    {
        Task<LaunchX[]?> GetAllLaunches();
    }
}