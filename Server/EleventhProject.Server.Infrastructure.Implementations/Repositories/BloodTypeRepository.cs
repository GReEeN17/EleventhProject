using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Infrastructure.Entities.BloodType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BloodTypeRepository : IBloodTypeRepository
{
    private readonly DataContext.DataContext _context;

    public BloodTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }

    public IQueryable<BloodTypeEntity> GetBloodType(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<BloodTypeEntity> GetBloodType()
    {
        throw new NotImplementedException();
    }

    public IQueryable<BloodTypeEntity> GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }

    public Task<BloodTypeEntity> CreateBloodType(BloodTypeModel bloodType)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBloodType(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveBloodType(BloodTypeModel bloodType)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBloodType(BloodTypeModel bloodType)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}