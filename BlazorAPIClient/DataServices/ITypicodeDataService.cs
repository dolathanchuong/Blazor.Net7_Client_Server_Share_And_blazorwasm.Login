using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public interface ITypicodeDataService
    {
        Task<LaunchDto[]?> GetAllLaunches();
    }
}