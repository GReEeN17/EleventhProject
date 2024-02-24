using EleventhProject.Server.Infrastructure.Entities.Abstractions;

namespace EleventhProject.Server.Infrastructure.Entities.City;

public class CityEntity : Entity
{
    public CityEntity(string title)
    {
        Title = title;
    }
    public string Title { get; set; }
}