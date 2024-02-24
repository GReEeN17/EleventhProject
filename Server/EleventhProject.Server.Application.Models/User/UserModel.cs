using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.City;

namespace EleventhProject.Server.Application.Models.User;

public class UserModel : Model
{
    public UserModel(CityModel city, string userName, string password, long phoneNumber, string surname,
        string name, string middleName)
    {
        City = city;
        UserName = userName;
        Password = password;
        Surname = surname;
        Name = name;
        MiddleName = middleName;
    }
    public int Id { get; set; }
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