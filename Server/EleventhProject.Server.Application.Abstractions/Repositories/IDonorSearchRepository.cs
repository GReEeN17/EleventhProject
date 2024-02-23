using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonorSearchRepository
{
    Task<DonorSearchCardModel> CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason,
        int bloodAmount, DateTime endDate, bool isUrgent);
}