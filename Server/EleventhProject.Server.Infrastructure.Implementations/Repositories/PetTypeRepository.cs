using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetTypeRepository : IPetTypeRepository
{
    private readonly DataContext.DataContext _context;

    public PetTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetTypeModel> GetPetType(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetTypeModel> GetPetType()
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetTypeModel> GetAllPetTypes()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreatePetType(PetTypeModel petType)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangePetTypes(IEnumerable<PetTypeModel> petTypes)
    {
        throw new NotImplementedException();
    }

    public Task DeletePetType(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public Task RemovePetType(PetTypeModel petType)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangePetTypes(IEnumerable<PetTypeModel> petTypes)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePetType(PetTypeModel petType)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangePetTypes(IEnumerable<PetTypeModel> petTypes)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}