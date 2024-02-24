using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface ICityRepository
{
    IQueryable<CityEntity> GetCity(int cityId);
    IQueryable<CityEntity> GetCity();
    IQueryable<CityEntity> GetAllCities();
    
    Task<CityEntity> CreateCity(CityEntity city);
    Task CreateRangeCities(IEnumerable<CityEntity> cities);

    Task DeleteCity(int cityId);

    Task RemoveBreed(CityEntity city);
    Task RemoveRangeBreeds(IEnumerable<CityEntity> cities);

    Task UpdateBreed(CityEntity city);
    Task UpdateRangeBreeds(IEnumerable<CityEntity> cities);
    
    Task<int> SaveChangesAsync();
}