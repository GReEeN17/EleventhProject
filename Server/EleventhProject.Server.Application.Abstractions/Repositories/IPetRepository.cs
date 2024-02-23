using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetRepository
{
    Task<PetModel> CreatePet(UserModel owner, PetTypeModel petType, BreedModel breed, BloodTypeModel bloodType,
        string name, int age, int weight);
}