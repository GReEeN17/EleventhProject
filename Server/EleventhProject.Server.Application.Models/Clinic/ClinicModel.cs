using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Models.Clinic;

public class ClinicModel : Model
{
    public string Title { get; set; }
    public string Address { get; set; }
    public CityModel City { get; set; }
}