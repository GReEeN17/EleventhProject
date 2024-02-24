using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetTypeRepository
{
    IQueryable<PetTypeEntity> GetPetType(int petTypeId);
    IQueryable<PetTypeEntity> GetPetType();
    IQueryable<PetTypeEntity> GetAllPetTypes();
    
    Task<PetTypeEntity> CreatePetType(PetTypeModel petType);
    Task CreateRangePetTypes(IEnumerable<PetTypeModel> petTypes);

    Task DeletePetType(int petTypeId);

    Task RemovePetType(PetTypeModel petType);
    Task RemoveRangePetTypes(IEnumerable<PetTypeModel> petTypes);

    Task UpdatePetType(PetTypeModel petType);
    Task UpdateRangePetTypes(IEnumerable<PetTypeModel> petTypes);
    
    Task<int> SaveChangesAsync();
}