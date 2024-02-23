using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.Contracts.BloodType;

public interface IBloodTypeService
{
    public BloodTypeModel CreateBloodType(string title);
}