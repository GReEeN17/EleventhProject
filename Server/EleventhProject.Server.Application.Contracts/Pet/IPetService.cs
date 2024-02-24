using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.Pet;

public interface IPetService
{
    Task<IActionResult> CreatePet(UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    Task<IActionResult> GetPetById(int petId);

    Task<IActionResult> UpdatePet(int petId, UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    IAsyncEnumerable<IActionResult> GetAllPetsByUserId(int userId);
}