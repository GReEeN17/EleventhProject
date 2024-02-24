using EleventhProject.Server.Application.Models.Breed;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBreedRepository
{
    IQueryable<BreedModel> GetBreed(int breedId);
    IQueryable<BreedModel> GetBreed();
    IQueryable<BreedModel> GetAllBreeds();
    
    Task<int> CreateBreed(BreedModel breed);
    Task CreateRangeBreeds(IEnumerable<BreedModel> breeds);

    Task DeleteBreed(int breedId);

    Task RemoveBreed(BreedModel breed);
    Task RemoveRangeBreeds(IEnumerable<BreedModel> breeds);

    Task UpdateBreed(BreedModel breed);
    Task UpdateRangeBreeds(IEnumerable<BreedModel> breeds);
    
    Task<int> SaveChangesAsync();
}