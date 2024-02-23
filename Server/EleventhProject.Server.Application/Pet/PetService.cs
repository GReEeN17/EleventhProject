using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Pet;

public class PetService : IPetService
{
    public PetModel CreatePet(UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        throw new NotImplementedException();
    }

    public PetModel GetPetById(int petId)
    {
        throw new NotImplementedException();
    }

    public PetModel UpdatePet(int petId, UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age,
        int weight)
    {
        throw new NotImplementedException();
    }
}