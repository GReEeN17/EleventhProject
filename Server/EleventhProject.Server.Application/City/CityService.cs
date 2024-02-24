using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.City;

public class CityService : ICityService
{
    public Task<CityModel> CreateCity(string title)
    {
        throw new NotImplementedException();
    }

    public Task<CityModel> GetCityById(int cityId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<CityModel> GetAllCities()
    {
        throw new NotImplementedException();
    }
}