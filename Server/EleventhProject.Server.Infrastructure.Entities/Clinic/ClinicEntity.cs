using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.City;

namespace EleventhProject.Server.Infrastructure.Entities.Clinic;

public class ClinicEntity : Entity
{
    public string Title { get; set; }
    public string Address { get; set; }
    public CityEntity City { get; set; }
}