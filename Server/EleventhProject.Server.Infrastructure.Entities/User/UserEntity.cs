using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.City;

namespace EleventhProject.Server.Infrastructure.Entities.User;

public class UserEntity : Entity
{
    public int CityId { get; set; }
    public CityEntity City { get; set; }
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