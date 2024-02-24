using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Models.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.City;

public class CityService : ICityService
{
    public Task<IActionResult> CreateCity(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetCityById(int cityId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllCities()
    {
        throw new NotImplementedException();
    }
}