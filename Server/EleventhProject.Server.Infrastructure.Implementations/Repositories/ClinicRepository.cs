using System.Linq.Expressions;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Infrastructure.Entities.Clinic;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class ClinicRepository : IClinicRepository
{
    private readonly DataContext.DataContext _context;

    public ClinicRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<ClinicEntity> GetClinic(Expression<Func<ClinicEntity, bool>> selector)
    {
        return _context.Set<ClinicEntity>().Where(selector).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<ClinicEntity> GetClinic()
    {
        return _context.Set<ClinicEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<ClinicEntity> GetAllClinics()
    {
        return _context.Set<ClinicEntity>().AsQueryable();

    }

    public async Task<ClinicEntity> CreateClinic(ClinicEntity clinic)
    {
        var entitiy = await _context.Set<ClinicEntity>().AddAsync(clinic);
        return entitiy.Entity;
    }

    public async Task CreateRangeClinics(IEnumerable<ClinicEntity> clinics)
    {
        await _context.Set<ClinicEntity>().AddRangeAsync(clinics);
    }

    public async Task DeleteClinic(int clinicId)
    {
        var activeEntity = await _context.Set<ClinicEntity>().FirstOrDefaultAsync(x => x.Id == clinicId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveClinic(ClinicEntity clinic)
    {
        await Task.Run(() => _context.Set<ClinicEntity>().Remove(clinic));
    }

    public async Task RemoveRangeClinics(IEnumerable<ClinicEntity> clinics)
    {
        await Task.Run(() => _context.Set<ClinicEntity>().RemoveRange(clinics));
    }

    public async Task UpdateClinic(ClinicEntity clinic)
    {
        await Task.Run(() => _context.Set<ClinicEntity>().Update(clinic));
    }

    public async Task UpdateRangeClinics(IEnumerable<ClinicEntity> clinics)
    {
        await Task.Run(() => _context.Set<ClinicEntity>().UpdateRange(clinics));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}