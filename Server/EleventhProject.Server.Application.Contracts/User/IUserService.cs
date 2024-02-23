using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.User;

public interface IUserService
{
    IPetService _petService { get; }
    IDonorSearchCardService _donorSearchCardService { get; }

    UserModel GetUserById(int id);

    UserModel CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate);

    void CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    IEnumerable<PetModel> GetAllPets(int userId);

    void CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate,
        bool IsUrgent);
}