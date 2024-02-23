using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Contracts.Pet;

public interface IPetService
{
    PetModel CreatePet(int ownerId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);
}