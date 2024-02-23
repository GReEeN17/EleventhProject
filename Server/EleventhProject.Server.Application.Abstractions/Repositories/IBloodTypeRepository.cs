using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IBloodTypeRepository
{
    Task<BloodTypeModel> CreateBloodType(string title);
}