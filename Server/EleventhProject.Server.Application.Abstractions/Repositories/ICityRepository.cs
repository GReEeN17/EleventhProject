using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface ICityRepository
{
    IQueryable<CityModel> GetCity(int cityId);
    IQueryable<CityModel> GetCity();
    IQueryable<CityModel> GetAllCities();
    
    Task<int> CreateCity(CityModel city);
    Task CreateRangeCities(IEnumerable<CityModel> cities);

    Task DeleteCity(int cityId);

    Task RemoveBreed(CityModel city);
    Task RemoveRangeBreeds(IEnumerable<CityModel> cities);

    Task UpdateBreed(CityModel city);
    Task UpdateRangeBreeds(IEnumerable<CityModel> cities);
    
    Task<int> SaveChangesAsync();
}