using EleventhProject.Server.Application.Models.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.City;

public interface ICityService
{
    Task<string> CreateCity(string title);

    Task<CityModel> GetCityById(int cityId);

    string GetAllCities();
}