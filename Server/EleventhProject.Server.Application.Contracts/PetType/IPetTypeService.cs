using EleventhProject.Server.Application.Models.PetType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.PetType;

public interface IPetTypeService
{
    Task<string> CreatePetType(string title);

    Task<IActionResult> GetPetTypeById(int petTypeId);

    IAsyncEnumerable<IActionResult> GetAllPetTypes();
}