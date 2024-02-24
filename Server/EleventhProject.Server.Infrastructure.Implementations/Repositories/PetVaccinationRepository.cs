using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetVaccinationRepository : IPetVaccinationRepository
{
    private readonly DataContext.DataContext _context;

    public PetVaccinationRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetVaccinationEntity> GetPetVaccination(int petVaccinationId)
    {
        return _context.Set<PetVaccinationEntity>().Where(x => x.Id == petVaccinationId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetVaccinationEntity> GetPetVaccination()
    {
        return _context.Set<PetVaccinationEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetVaccinationEntity> GetAllPetVaccinations()
    {
        return _context.Set<PetVaccinationEntity>().AsQueryable();
    }

    public async Task<PetVaccinationEntity> CreatePetVaccination(PetVaccinationEntity petVaccination)
    {
        var entitiy = await _context.Set<PetVaccinationEntity>().AddAsync(petVaccination);
        return entitiy.Entity;
    }

    public async Task CreateRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations)
    {
        await _context.Set<PetVaccinationEntity>().AddRangeAsync(petVaccinations);
    }

    public async Task DeletePetVaccination(int petVaccinationId)
    {
        var activeEntity = await _context.Set<PetVaccinationEntity>().FirstOrDefaultAsync(x => x.Id == petVaccinationId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemovePetVaccination(PetVaccinationEntity petVaccination)
    {
        await Task.Run(() => _context.Set<PetVaccinationEntity>().Remove(petVaccination));
    }

    public async Task RemoveRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations)
    {
        await Task.Run(() => _context.Set<PetVaccinationEntity>().RemoveRange(petVaccinations));
    }

    public async Task UpdatePetVaccination(PetVaccinationEntity petVaccination)
    {
        await Task.Run(() => _context.Set<PetVaccinationEntity>().Update(petVaccination));
    }

    public async Task UpdateRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations)
    {
        await Task.Run(() => _context.Set<PetVaccinationEntity>().UpdateRange(petVaccinations));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}