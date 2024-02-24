using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Infrastructure.Entities.BloodType;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BloodTypeRepository : IBloodTypeRepository
{
    private readonly DataContext.DataContext _context;

    public BloodTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }

    public IQueryable<BloodTypeEntity> GetBloodType(int bloodTypeId)
    {
        return _context.Set<BloodTypeEntity>().Where(x => x.Id == bloodTypeId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<BloodTypeEntity> GetBloodType()
    {
        return _context.Set<BloodTypeEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<BloodTypeEntity> GetAllBloodTypes()
    {
        return _context.Set<BloodTypeEntity>().AsQueryable();
    }

    public async Task<BloodTypeEntity> CreateBloodType(BloodTypeEntity bloodType)
    {
        var entitiy = await _context.Set<BloodTypeEntity>().AddAsync(bloodType);
        return entitiy.Entity;
    }

    public async Task CreateRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes)
    {
        await _context.Set<BloodTypeEntity>().AddRangeAsync(bloodTypes);
    }

    public async Task DeleteBloodType(int bloodTypeId)
    {
        var activeEntity = await _context.Set<BloodTypeEntity>().FirstOrDefaultAsync(x => x.Id == bloodTypeId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveBloodType(BloodTypeEntity bloodType)
    {
        await Task.Run(() => _context.Set<BloodTypeEntity>().Remove(bloodType));
    }

    public async Task RemoveRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes)
    {
        await Task.Run(() => _context.Set<BloodTypeEntity>().RemoveRange(bloodTypes));
    }

    public async Task UpdateBloodType(BloodTypeEntity bloodType)
    {
        await Task.Run(() => _context.Set<BloodTypeEntity>().Update(bloodType));
    }

    public async Task UpdateRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes)
    {
        await Task.Run(() => _context.Set<BloodTypeEntity>().UpdateRange(bloodTypes));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}