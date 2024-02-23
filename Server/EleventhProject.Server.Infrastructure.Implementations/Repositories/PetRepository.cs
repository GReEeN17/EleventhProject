using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetRepository : IPetRepository
{
    public Task<PetModel> CreatePet(UserModel owner, PetTypeModel petType, BreedModel breed, BloodTypeModel bloodType, string name, int age,
        int weight)
    {
        throw new NotImplementedException();
    }
}