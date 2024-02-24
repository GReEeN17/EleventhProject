using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.DonorSearchCard;

public interface IDonorSearchCardService
{
    Task<DonorSearchCardModel> CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason, int bloodAmount,
        DateTime endDate, bool isUrgent);

    Task<DonorSearchCardModel> GetDonorSearchCardById(int donorSearchCardId);

    IAsyncEnumerable<DonorSearchCardModel> GetDonorSearchCardsByCity(int cityId);
}