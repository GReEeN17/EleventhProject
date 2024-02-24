using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Infrastructure.Entities.BloodType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBloodTypeRepository
{
    IQueryable<BloodTypeEntity> GetBloodType(int bloodTypeId);
    IQueryable<BloodTypeEntity> GetBloodType();
    IQueryable<BloodTypeEntity> GetAllBloodTypes();
    
    Task<BloodTypeEntity> CreateBloodType(BloodTypeEntity bloodType);
    Task CreateRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes);

    Task DeleteBloodType(int bloodTypeId);

    Task RemoveBloodType(BloodTypeEntity bloodType);
    Task RemoveRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes);

    Task UpdateBloodType(BloodTypeEntity bloodType);
    Task UpdateRangeBloodTypes(IEnumerable<BloodTypeEntity> bloodTypes);
    
    Task<int> SaveChangesAsync();
}