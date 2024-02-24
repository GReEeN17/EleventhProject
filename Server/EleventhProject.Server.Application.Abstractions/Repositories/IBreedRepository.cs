using System.Linq.Expressions;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Infrastructure.Entities.Breed;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBreedRepository
{
    IQueryable<BreedEntity> GetBreed(Expression<Func<BreedEntity, bool>> selector);
    IQueryable<BreedEntity> GetBreed();
    IQueryable<BreedEntity> GetAllBreeds();
    
    Task<BreedEntity> CreateBreed(BreedEntity breed);
    Task CreateRangeBreeds(IEnumerable<BreedEntity> breeds);

    Task DeleteBreed(int breedId);

    Task RemoveBreed(BreedEntity breed);
    Task RemoveRangeBreeds(IEnumerable<BreedEntity> breeds);

    Task UpdateBreed(BreedEntity breed);
    Task UpdateRangeBreeds(IEnumerable<BreedEntity> breeds);
    
    Task<int> SaveChangesAsync();
}