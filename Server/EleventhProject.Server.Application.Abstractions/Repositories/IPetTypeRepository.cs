using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetTypeRepository
{
    IQueryable<PetTypeEntity> GetPetType(int petTypeId);
    IQueryable<PetTypeEntity> GetPetType();
    IQueryable<PetTypeEntity> GetAllPetTypes();
    
    Task<PetTypeEntity> CreatePetType(PetTypeEntity petType);
    Task CreateRangePetTypes(IEnumerable<PetTypeEntity> petTypes);

    Task DeletePetType(int petTypeId);

    Task RemovePetType(PetTypeEntity petType);
    Task RemoveRangePetTypes(IEnumerable<PetTypeEntity> petTypes);

    Task UpdatePetType(PetTypeEntity petType);
    Task UpdateRangePetTypes(IEnumerable<PetTypeEntity> petTypes);
    
    Task<int> SaveChangesAsync();
}