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

    UserModel GetUserById(int id);

    UserModel CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);
    
    UserModel UpdateUser(int userId, int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);

    void CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    IEnumerable<PetModel> GetAllPets(int userId);

    void CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate,
        bool IsUrgent);

    IEnumerable<DonationHistoryModel> GetDonationHistory(int userId);
}