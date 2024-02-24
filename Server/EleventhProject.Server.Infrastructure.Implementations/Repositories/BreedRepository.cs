using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Breed;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BreedRepository : IBreedRepository
{
    private readonly DataContext.DataContext _context;

    public BreedRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<BreedModel> GetBreed(int breedId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<BreedModel> GetBreed()
    {
        throw new NotImplementedException();
    }

    public IQueryable<BreedModel> GetAllBreeds()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateBreed(BreedModel breed)
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