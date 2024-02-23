using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.Contracts.BloodType;

public interface IBloodTypeService
{
    BloodTypeModel CreateBloodType(string title);

    BloodTypeModel GetBloodTypeById(int bloodTypeId);
}