using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class CityRepository : ICityRepository
{
    private readonly DataContext.DataContext _context;

    public CityRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<CityEntity> GetCity(int cityId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<CityEntity> GetCity()
    {
        throw new NotImplementedException();
    }

    public IQueryable<CityEntity> GetAllCities()
    {
        throw new NotImplementedException();
    }

    public Task<CityEntity> CreateCity(CityModel city)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeCities(IEnumerable<CityModel> cities)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCity(int cityId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveBreed(CityModel city)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeBreeds(IEnumerable<CityModel> cities)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBreed(CityModel city)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeBreeds(IEnumerable<CityModel> cities)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}