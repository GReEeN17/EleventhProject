using EleventhProject.Server.Application.Models.Breed;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBreedRepository
{
    Task<BreedModel> CreateBreed(string title);
}