using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Models.User;

public class UserModel : Model
{
    public CityModel City { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public long PhoneNumber { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string MiddleName { get; set; }
    public bool NotReadyForDonation { get; set; }
    public DateTime? AbsenceBeginDate { get; set; }
    public DateTime? AbsenceEndDate { get; set; }
}