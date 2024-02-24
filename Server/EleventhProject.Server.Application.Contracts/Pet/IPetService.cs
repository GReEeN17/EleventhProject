using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.Pet;

public interface IPetService
{
    Task<PetModel> CreatePet(UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    Task<PetModel> GetPetById(int petId);

    Task<PetModel> UpdatePet(int petId, UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    IAsyncEnumerable<PetModel> GetAllPetsByUserId(int userId);
}