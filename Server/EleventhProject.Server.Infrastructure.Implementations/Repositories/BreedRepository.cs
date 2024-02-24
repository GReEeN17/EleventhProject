using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Infrastructure.Entities.Breed;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BreedRepository : IBreedRepository
{
    private readonly DataContext.DataContext _context;

    public BreedRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<BreedEntity> GetBreed(int breedId)
    {
        return _context.Set<BreedEntity>().Where(x => x.Id == breedId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<BreedEntity> GetBreed()
    {
        return _context.Set<BreedEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<BreedEntity> GetAllBreeds()
    {
        return _context.Set<BreedEntity>().AsQueryable();
    }

    public async Task<BreedEntity> CreateBreed(BreedEntity breed)
    {
        var entitiy = await _context.Set<BreedEntity>().AddAsync(breed);
        return entitiy.Entity;
    }

    public async Task CreateRangeBreeds(IEnumerable<BreedEntity> breeds)
    {
        await _context.Set<BreedEntity>().AddRangeAsync(breeds);
    }

    public async Task DeleteBreed(int breedId)
    {
        var activeEntity = await _context.Set<BreedEntity>().FirstOrDefaultAsync(x => x.Id == breedId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveBreed(BreedEntity breed)
    {
        await Task.Run(() => _context.Set<BreedEntity>().Remove(breed));
    }

    public async Task RemoveRangeBreeds(IEnumerable<BreedEntity> breeds)
    {
        await Task.Run(() => _context.Set<BreedEntity>().RemoveRange(breeds));
    }

    public async Task UpdateBreed(BreedEntity breed)
    {
        await Task.Run(() => _context.Set<BreedEntity>().Update(breed));
    }

    public async Task UpdateRangeBreeds(IEnumerable<BreedEntity> breeds)
    {
        await Task.Run(() => _context.Set<BreedEntity>().UpdateRange(breeds));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}