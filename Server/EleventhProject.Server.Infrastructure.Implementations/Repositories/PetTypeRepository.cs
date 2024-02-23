using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetType;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetTypeRepository : IPetTypeRepository
{
    public Task<PetTypeModel> CreatePetType(string title)
    {
        throw new NotImplementedException();
    }
}