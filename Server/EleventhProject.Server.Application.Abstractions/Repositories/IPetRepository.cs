using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetRepository
{
    IQueryable<PetModel> GetPet(int petId);
    IQueryable<PetModel> GetPet();
    IQueryable<PetModel> GetAllPets();
    
    Task<int> CreatePet(PetModel pet);
    Task CreateRangePets(IEnumerable<PetModel> pets);

    Task DeletePet(int petId);

    Task RemovePet(PetModel pet);
    Task RemoveRangePets(IEnumerable<PetModel> pets);

    Task UpdatePet(PetModel pet);
    Task UpdateRangePets(IEnumerable<PetModel> pets);
    
    Task<int> SaveChangesAsync();
}