using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface ICityRepository
{
    IQueryable<CityEntity> GetCity(int cityId);
    IQueryable<CityEntity> GetCity();
    IQueryable<CityEntity> GetAllCities();
    
    Task<CityEntity> CreateCity(CityModel city);
    Task CreateRangeCities(IEnumerable<CityModel> cities);

    Task DeleteCity(int cityId);

    Task RemoveBreed(CityModel city);
    Task RemoveRangeBreeds(IEnumerable<CityModel> cities);

    Task UpdateBreed(CityModel city);
    Task UpdateRangeBreeds(IEnumerable<CityModel> cities);
    
    Task<int> SaveChangesAsync();
}