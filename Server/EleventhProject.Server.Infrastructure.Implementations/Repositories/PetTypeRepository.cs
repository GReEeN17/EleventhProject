using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetTypeRepository : IPetTypeRepository
{
    private readonly DataContext.DataContext _context;

    public PetTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetTypeEntity> GetPetType(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetTypeEntity> GetPetType()
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetTypeEntity> GetAllPetTypes()
    {
        throw new NotImplementedException();
    }

    public Task<PetTypeEntity> CreatePetType(PetTypeModel petType)
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