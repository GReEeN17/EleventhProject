using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class BloodTypeRepository : IBloodTypeRepository
{
    public Task<BloodTypeModel> CreateBloodType(string title)
    {
        throw new NotImplementedException();
    }
}