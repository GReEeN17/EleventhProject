using EleventhProject.Server.Application.Models.Breed;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.Breed;

public interface IBreedService
{
    Task<BreedModel> CreateBreed(string title);

    Task<BreedModel> GetBreedById(int breedId);

    IAsyncEnumerable<BreedModel> GetAllBreeds();
}