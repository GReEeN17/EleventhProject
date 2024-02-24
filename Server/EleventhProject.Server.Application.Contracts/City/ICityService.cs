using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Contracts.City;

public interface ICityService
{
    CityModel CreateCity(string title);

    CityModel GetCityById(int cityId);

    IEnumerable<CityModel> GetAllCities();
}