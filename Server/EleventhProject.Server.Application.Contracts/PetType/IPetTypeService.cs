using EleventhProject.Server.Application.Models.PetType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.PetType;

public interface IPetTypeService
{
    Task<PetTypeModel> CreatePetType(string title);

    Task<PetTypeModel> GetPetTypeById(int petTypeId);

    IAsyncEnumerable<PetTypeModel> GetAllPetTypes();
}