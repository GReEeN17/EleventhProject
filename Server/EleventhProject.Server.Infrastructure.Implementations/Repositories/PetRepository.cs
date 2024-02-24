using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.Pet;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetRepository : IPetRepository
{
    private readonly DataContext.DataContext _context;

    public PetRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetEntity> GetPet(int petId)
    {
        return _context.Set<PetEntity>().Where(x => x.Id == petId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetEntity> GetPet()
    {
        return _context.Set<PetEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<PetEntity> GetAllPets()
    {
        return _context.Set<PetEntity>().AsQueryable();
    }

    public async Task<PetEntity> CreatePet(PetEntity pet)
    {
        var entitiy = await _context.Set<PetEntity>().AddAsync(pet);
        return entitiy.Entity;
    }

    public async Task CreateRangePets(IEnumerable<PetEntity> pets)
    {
        await _context.Set<PetEntity>().AddRangeAsync(pets);
    }

    public async Task DeletePet(int petId)
    {
        var activeEntity = await _context.Set<PetEntity>().FirstOrDefaultAsync(x => x.Id == petId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemovePet(PetEntity pet)
    {
        await Task.Run(() => _context.Set<PetEntity>().Remove(pet));
    }

    public async Task RemoveRangePets(IEnumerable<PetEntity> pets)
    {
        await Task.Run(() => _context.Set<PetEntity>().RemoveRange(pets));
    }

    public async Task UpdatePet(PetEntity pet)
    {
        await Task.Run(() => _context.Set<PetEntity>().Update(pet));
    }

    public async Task UpdateRangePets(IEnumerable<PetEntity> pets)
    {
        await Task.Run(() => _context.Set<PetEntity>().UpdateRange(pets));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}