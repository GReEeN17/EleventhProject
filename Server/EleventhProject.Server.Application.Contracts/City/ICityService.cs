using System.Linq.Expressions;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.City;

public interface ICityService
{
    Task<string> CreateCity(string title);

    Task<CityModel> GetCity(Expression<Func<CityEntity, bool>> selector);

    string GetAllCities();
}