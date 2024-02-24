using EleventhProject.Server.Application.Contracts.PetType;
using EleventhProject.Server.Application.Models.PetType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.PetType;

public class PetTypeService : IPetTypeService
{
    public Task<IActionResult> CreatePetType(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetPetTypeById(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllPetTypes()
    {
        throw new NotImplementedException();
    }
}