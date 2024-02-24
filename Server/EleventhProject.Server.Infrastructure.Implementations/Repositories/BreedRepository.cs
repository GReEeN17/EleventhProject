using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Infrastructure.Entities.Breed;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BreedRepository : IBreedRepository
{
    private readonly DataContext.DataContext _context;

    public BreedRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<BreedEntity> GetBreed(int breedId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<BreedEntity> GetBreed()
    {
        throw new NotImplementedException();
    }

    public IQueryable<BreedEntity> GetAllBreeds()
    {
        throw new NotImplementedException();
    }

    public Task<BreedEntity> CreateBreed(BreedModel breed)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeBreeds(IEnumerable<BreedModel> breeds)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBreed(int breedId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveBreed(BreedModel breed)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeBreeds(IEnumerable<BreedModel> breeds)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBreed(BreedModel breed)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeBreeds(IEnumerable<BreedModel> breeds)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}