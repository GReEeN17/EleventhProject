using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BloodTypeRepository : IBloodTypeRepository
{
    private readonly DataContext.DataContext _context;

    public BloodTypeRepository(DataContext.DataContext context)
    {
        _context = context;
    }

    public IQueryable<BloodTypeModel> GetBloodType(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<BloodTypeModel> GetBloodType()
    {
        throw new NotImplementedException();
    }

    public IQueryable<BloodTypeModel> GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateBloodType(BloodTypeModel bloodType)
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