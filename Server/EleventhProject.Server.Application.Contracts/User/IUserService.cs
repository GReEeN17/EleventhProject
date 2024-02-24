using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.User;

public interface IUserService
{
    Task<UserModel> GetUserById(int id);

    Task<string> Login(string username, string password);

    Task<UserModel> CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName);
    
    Task<string> UpdateUser(int userId, int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName, bool notReadyForDonation, DateTime? AbsenceBeginDate, DateTime? AbsenceEndDate);

    Task<PetModel> CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight);

    Task CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate,
        bool IsUrgent);

    IAsyncEnumerable<string> GetDonationHistory(int userId);
}