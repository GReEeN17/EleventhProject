using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Infrastructure.Entities.BloodType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBloodTypeRepository
{
    IQueryable<BloodTypeEntity> GetBloodType(int bloodTypeId);
    IQueryable<BloodTypeEntity> GetBloodType();
    IQueryable<BloodTypeEntity> GetAllBloodTypes();
    
    Task<BloodTypeEntity> CreateBloodType(BloodTypeModel bloodType);
    Task CreateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);

    Task DeleteBloodType(int bloodTypeId);

    Task RemoveBloodType(BloodTypeModel bloodType);
    Task RemoveRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);

    Task UpdateBloodType(BloodTypeModel bloodType);
    Task UpdateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);
    
    Task<int> SaveChangesAsync();
}