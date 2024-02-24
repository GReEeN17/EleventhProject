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

    Task RemoveCity(CityEntity city);
    Task RemoveRangeCities(IEnumerable<CityEntity> cities);

    Task UpdateCity(CityEntity city);
    Task UpdateRangeCities(IEnumerable<CityEntity> cities);
    
    Task<int> SaveChangesAsync();
}