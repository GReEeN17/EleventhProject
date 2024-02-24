using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetTypeRepository
{
    IQueryable<PetTypeModel> GetPetType(int petTypeId);
    IQueryable<PetTypeModel> GetPetType();
    IQueryable<PetTypeModel> GetAllPetTypes();
    
    Task<int> CreatePetType(PetTypeModel petType);
    Task CreateRangePetTypes(IEnumerable<PetTypeModel> petTypes);

    Task DeletePetType(int petTypeId);

    Task RemovePetType(PetTypeModel petType);
    Task RemoveRangePetTypes(IEnumerable<PetTypeModel> petTypes);

    Task UpdatePetType(PetTypeModel petType);
    Task UpdateRangePetTypes(IEnumerable<PetTypeModel> petTypes);
    
    Task<int> SaveChangesAsync();
}