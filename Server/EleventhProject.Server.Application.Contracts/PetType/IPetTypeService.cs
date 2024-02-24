using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Application.Contracts.PetType;

public interface IPetTypeService
{
    Task<PetTypeModel> CreatePetType(string title);

    Task<PetTypeModel> GetPetTypeById(int petTypeId);

    IAsyncEnumerable<PetTypeModel> GetAllPetTypes();
}