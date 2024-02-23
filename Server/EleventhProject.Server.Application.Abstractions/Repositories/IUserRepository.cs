using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IUserRepository
{
    Task<UserModel> CreateUser(CityModel city, string userName, string password, long phoneNumber, string surname,
        string name, string middleName, bool notReadyForDonation, DateTime? absenceBeginDate, DateTime? absenceEndDate);
}