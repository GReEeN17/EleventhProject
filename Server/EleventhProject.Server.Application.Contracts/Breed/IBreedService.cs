using EleventhProject.Server.Application.Models.Breed;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.Breed;

public interface IBreedService
{
    Task<IActionResult> CreateBreed(string title);

    Task<IActionResult> GetBreedById(int breedId);

    IAsyncEnumerable<IActionResult> GetAllBreeds();
}