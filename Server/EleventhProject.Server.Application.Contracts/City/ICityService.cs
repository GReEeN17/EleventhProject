using EleventhProject.Server.Application.Models.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.City;

public interface ICityService
{
    Task<IActionResult> CreateCity(string title);

    Task<IActionResult> GetCityById(int cityId);

    IAsyncEnumerable<IActionResult> GetAllCities();
}