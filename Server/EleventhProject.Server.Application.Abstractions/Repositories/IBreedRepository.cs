using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Infrastructure.Entities.Breed;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBreedRepository
{
    IQueryable<BreedEntity> GetBreed(int breedId);
    IQueryable<BreedEntity> GetBreed();
    IQueryable<BreedEntity> GetAllBreeds();
    
    Task<BreedEntity> CreateBreed(BreedModel breed);
    Task CreateRangeBreeds(IEnumerable<BreedModel> breeds);

    Task DeleteBreed(int breedId);

    Task RemoveBreed(BreedModel breed);
    Task RemoveRangeBreeds(IEnumerable<BreedModel> breeds);

    Task UpdateBreed(BreedModel breed);
    Task UpdateRangeBreeds(IEnumerable<BreedModel> breeds);
    
    Task<int> SaveChangesAsync();
}