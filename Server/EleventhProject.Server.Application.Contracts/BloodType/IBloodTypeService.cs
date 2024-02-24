using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.Contracts.BloodType;

public interface IBloodTypeService
{
    Task<BloodTypeModel> CreateBloodType(string title);

    Task<BloodTypeModel> GetBloodTypeById(int bloodTypeId);

    IAsyncEnumerable<BloodTypeModel> GetAllBloodTypes();
}