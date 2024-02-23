using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetTypeRepository
{
    Task<PetTypeModel> CreatePetType(string title);
}