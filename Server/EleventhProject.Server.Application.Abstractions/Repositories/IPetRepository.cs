using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Infrastructure.Entities.Pet;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetRepository
{
    IQueryable<PetEntity> GetPet(int petId);
    IQueryable<PetEntity> GetPet();
    IQueryable<PetEntity> GetAllPets();
    
    Task<PetEntity> CreatePet(PetModel pet);
    Task CreateRangePets(IEnumerable<PetModel> pets);

    Task DeletePet(int petId);

    Task RemovePet(PetModel pet);
    Task RemoveRangePets(IEnumerable<PetModel> pets);

    Task UpdatePet(PetModel pet);
    Task UpdateRangePets(IEnumerable<PetModel> pets);
    
    Task<int> SaveChangesAsync();
}