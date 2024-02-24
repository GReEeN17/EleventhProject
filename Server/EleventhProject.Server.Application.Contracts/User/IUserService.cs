using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.User;

public interface IUserService
{
    IPetService PetService { get; }
    IDonorSearchCardService DonorSearchCardService { get; }
    IUserRepository UserRepository { get; }

    Task<UserModel> GetUserById(int id);

    Task<UserModel> CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);
    
    Task<UserModel> UpdateUser(int userId, int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);

    Task CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    IAsyncEnumerable<PetModel> GetAllPets(int userId);

    Task CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate,
        bool IsUrgent);

    IAsyncEnumerable<DonationHistoryModel> GetDonationHistory(int userId);
}