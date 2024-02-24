using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetType;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetTypeRepository : IPetTypeRepository
{
    private readonly DataContext.DataContext _context;

    public PetTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetTypeEntity> GetPetType(int petTypeId)
    {
        return _context.Set<PetTypeEntity>().Where(x => x.Id == petTypeId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetTypeEntity> GetPetType()
    {
        return _context.Set<PetTypeEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetTypeEntity> GetAllPetTypes()
    {
        return _context.Set<PetTypeEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public async Task<PetTypeEntity> CreatePetType(PetTypeEntity petType)
    {
        var entitiy = await _context.Set<PetTypeEntity>().AddAsync(petType);
        return entitiy.Entity;
    }

    public async Task CreateRangePetTypes(IEnumerable<PetTypeEntity> petTypes)
    {
        await _context.Set<PetTypeEntity>().AddRangeAsync(petTypes);
    }

    public async Task DeletePetType(int petTypeId)
    {
        var activeEntity = await _context.Set<PetTypeEntity>().FirstOrDefaultAsync(x => x.Id == petTypeId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemovePetType(PetTypeEntity petType)
    {
        await Task.Run(() => _context.Set<PetTypeEntity>().Remove(petType));
    }

    public async Task RemoveRangePetTypes(IEnumerable<PetTypeEntity> petTypes)
    {
        await Task.Run(() => _context.Set<PetTypeEntity>().RemoveRange(petTypes));
    }

    public async Task UpdatePetType(PetTypeEntity petType)
    {
        await Task.Run(() => _context.Set<PetTypeEntity>().Update(petType));
    }

    public async Task UpdateRangePetTypes(IEnumerable<PetTypeEntity> petTypes)
    {
        await Task.Run(() => _context.Set<PetTypeEntity>().UpdateRange(petTypes));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}