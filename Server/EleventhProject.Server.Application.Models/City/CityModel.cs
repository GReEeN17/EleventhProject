using EleventhProject.Server.Application.Models.Abstractions;

namespace EleventhProject.Server.Application.Models.City;

public class CityModel(string title) : Model
{
    public string Title { get; set; } = title;
}