using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.User;

public interface IUserService
{
    UserModel CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);
}