using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Breed;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BreedRepository : IBreedRepository
{
    public Task<BreedModel> CreateBreed(string title)
    {
        throw new NotImplementedException();
    }
}