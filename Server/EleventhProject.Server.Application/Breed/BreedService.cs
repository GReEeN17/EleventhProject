using EleventhProject.Server.Application.Contracts.Breed;
using EleventhProject.Server.Application.Models.Breed;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Breed;

public class BreedService : IBreedService
{
    public Task<IActionResult> CreateBreed(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetBreedById(int breedId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllBreeds()
    {
        throw new NotImplementedException();
    }
}