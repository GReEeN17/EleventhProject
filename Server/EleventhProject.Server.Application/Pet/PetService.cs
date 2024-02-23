using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Pet;

public class PetService : IPetService
{
    public PetModel CreatePet(int ownerId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        throw new NotImplementedException();
    }
}