using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;
using Microsoft.EntityFrameworkCore;

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
        return _context.Set<CityEntity>().Where(x => x.Id == cityId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<CityEntity> GetCity()
    {
        return _context.Set<CityEntity>().Where(x => x.IsActive).AsQueryable();

    }

    public IQueryable<CityEntity> GetAllCities()
    {
        return _context.Set<CityEntity>().AsQueryable();
    }

    public async Task<CityEntity> CreateCity(CityEntity city)
    {
        var entitiy = await _context.Set<CityEntity>().AddAsync(city);
        return entitiy.Entity;
    }

    public async Task CreateRangeCities(IEnumerable<CityEntity> cities)
    {
        await _context.Set<CityEntity>().AddRangeAsync(cities);
    }

    public async Task DeleteCity(int cityId)
    {
        var activeEntity = await _context.Set<CityEntity>().FirstOrDefaultAsync(x => x.Id == cityId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveCity(CityEntity city)
    {
        await Task.Run(() => _context.Set<CityEntity>().Remove(city));
    }

    public async Task RemoveRangeCities(IEnumerable<CityEntity> cities)
    {
        await Task.Run(() => _context.Set<CityEntity>().RemoveRange(cities));
    }

    public async Task UpdateCity(CityEntity city)
    {
        await Task.Run(() => _context.Set<CityEntity>().Update(city));
    }

    public async Task UpdateRangeCities(IEnumerable<CityEntity> cities)
    {
        await Task.Run(() => _context.Set<CityEntity>().UpdateRange(cities));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}