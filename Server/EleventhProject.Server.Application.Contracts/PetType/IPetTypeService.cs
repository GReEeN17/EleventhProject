using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Application.Contracts.PetType;

public interface IPetTypeService
{
    PetTypeModel CreatePetType(string title);

    PetTypeModel GetPetTypeById(int petTypeId);

    IEnumerable<PetTypeModel> GetAllPetTypes();
}