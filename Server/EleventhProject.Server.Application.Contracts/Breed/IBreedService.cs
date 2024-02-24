using EleventhProject.Server.Application.Models.Breed;

namespace EleventhProject.Server.Application.Contracts.Breed;

public interface IBreedService
{
    BreedModel CreateBreed(string title);

    BreedModel GetBreedById(int breedId);

    IEnumerable<BreedModel> GetAllBreeds();
}