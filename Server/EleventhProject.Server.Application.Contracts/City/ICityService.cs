using EleventhProject.Server.Application.Models.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.City;

public interface ICityService
{
    Task<CityModel> CreateCity(string title);

    Task<CityModel> GetCityById(int cityId);

    IAsyncEnumerable<CityModel> GetAllCities();
}