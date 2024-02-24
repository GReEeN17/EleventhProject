using System.Linq.Expressions;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Infrastructure.Entities.Pet;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetRepository
{
    IQueryable<PetEntity> GetPet(Expression<Func<PetEntity, bool>> selector);
    IQueryable<PetEntity> GetPet();
    IQueryable<PetEntity> GetAllPets();
    
    Task<PetEntity> CreatePet(PetEntity pet);
    Task CreateRangePets(IEnumerable<PetEntity> pets);

    Task DeletePet(int petId);

    Task RemovePet(PetEntity pet);
    Task RemoveRangePets(IEnumerable<PetEntity> pets);

    Task UpdatePet(PetEntity pet);
    Task UpdateRangePets(IEnumerable<PetEntity> pets);
    
    Task<int> SaveChangesAsync();
}