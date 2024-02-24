using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class VaccinationDictRepository : IVaccinationDictRepository
{
    private readonly DataContext.DataContext _context;

    public VaccinationDictRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<VaccinationDictEntity> GetVaccinationDict(int vaccinationDictId)
    {
        return _context.Set<VaccinationDictEntity>().Where(x => x.Id == vaccinationDictId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<VaccinationDictEntity> GetVaccinationDict()
    {
        return _context.Set<VaccinationDictEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<VaccinationDictEntity> GetAllVaccinationDicts()
    {
        return _context.Set<VaccinationDictEntity>().AsQueryable();
    }

    public async Task<VaccinationDictEntity> CreateVaccinationDict(VaccinationDictEntity vaccinationDict)
    {
        var entitiy = await _context.Set<VaccinationDictEntity>().AddAsync(vaccinationDict);
        return entitiy.Entity;
    }
    public async Task CreateRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts)
    {
        await _context.Set<VaccinationDictEntity>().AddRangeAsync(vaccinationDicts);
    }

    public async Task DeleteVaccinationDict(int vaccinationDictId)
    {
        var activeEntity = await _context.Set<VaccinationDictEntity>().FirstOrDefaultAsync(x => x.Id == vaccinationDictId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveVaccinationDict(VaccinationDictEntity vaccinationDict)
    {
        await Task.Run(() => _context.Set<VaccinationDictEntity>().Remove(vaccinationDict));
    }

    public async Task RemoveRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts)
    {
        await Task.Run(() => _context.Set<VaccinationDictEntity>().RemoveRange(vaccinationDicts));
    }

    public async Task UpdateVaccinationDict(VaccinationDictEntity vaccinationDict)
    {
        await Task.Run(() => _context.Set<VaccinationDictEntity>().Update(vaccinationDict));
    }

    public async Task UpdateRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts)
    {
        await Task.Run(() => _context.Set<VaccinationDictEntity>().UpdateRange(vaccinationDicts));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}