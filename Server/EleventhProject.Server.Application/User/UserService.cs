using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.User;

public class UserService : IUserService
{
    public IPetService PetService { get; }
    public IDonorSearchCardService DonorSearchCardService { get; }
    public IUserRepository UserRepository { get; }

    public Task<UserModel> GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> UpdateUser(int userId, int cityId, string username, string password, long phoneNumber, string surname,
        string name, string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate)
    {
        throw new NotImplementedException();
    }

    public Task CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<PetModel> GetAllPets(int userId)
    {
        throw new NotImplementedException();
    }

    public Task CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate, bool IsUrgent)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<DonationHistoryModel> GetDonationHistory(int userId)
    {
        throw new NotImplementedException();
    }
}