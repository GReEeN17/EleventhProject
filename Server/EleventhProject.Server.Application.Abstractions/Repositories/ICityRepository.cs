using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface ICityRepository
{
    Task<CityModel> CreateCity(string title);
}