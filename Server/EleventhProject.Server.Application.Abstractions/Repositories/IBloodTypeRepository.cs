using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBloodTypeRepository
{
    IQueryable<BloodTypeModel> GetBloodType(int bloodTypeId);
    IQueryable<BloodTypeModel> GetBloodType();
    IQueryable<BloodTypeModel> GetAllBloodTypes();
    
    Task<int> CreateBloodType(BloodTypeModel bloodType);
    Task CreateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);

    Task DeleteBloodType(int bloodTypeId);

    Task RemoveBloodType(BloodTypeModel bloodType);
    Task RemoveRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);

    Task UpdateBloodType(BloodTypeModel bloodType);
    Task UpdateRangeBloodTypes(IEnumerable<BloodTypeModel> bloodTypes);
    
    Task<int> SaveChangesAsync();
}