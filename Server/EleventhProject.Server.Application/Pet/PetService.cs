using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Pet;

public class PetService : IPetService
{
    public Task<IActionResult> CreatePet(UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetPetById(int petId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> UpdatePet(int petId, UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age,
        int weight)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllPetsByUserId(int userId)
    {
        throw new NotImplementedException();
    }
}