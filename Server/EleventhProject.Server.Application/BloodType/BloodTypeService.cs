using EleventhProject.Server.Application.Contracts.BloodType;
using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.BloodType;

public class BloodTypeService : IBloodTypeService
{
    public Task<BloodTypeModel> CreateBloodType(string title)
    {
        throw new NotImplementedException();
    }

    public Task<BloodTypeModel> GetBloodTypeById(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<BloodTypeModel> GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }
}