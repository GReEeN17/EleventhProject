using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.Pet;

public interface IPetService
{
    PetModel CreatePet(UserModel owner, PetTypeModel petType, BreedModel breed, BloodTypeModel bloodType, string name, int age, int weight);

    PetModel GetPetById(int petId);
}