using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.User;

public class UserService : IUserService
{
    public UserModel CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate)
    {
        throw new NotImplementedException();
    }
}