using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class CityRepository : ICityRepository
{
    private readonly DataContext.DataContext _context;

    public CityRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<CityModel> GetCity(int cityId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<CityModel> GetCity()
    {
        throw new NotImplementedException();
    }

    public IQueryable<CityModel> GetAllCities()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateCity(CityModel city)
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