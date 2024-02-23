using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class CityRepository : ICityRepository
{
    public Task<CityModel> CreateCity(string title)
    {
        throw new NotImplementedException();
    }
}