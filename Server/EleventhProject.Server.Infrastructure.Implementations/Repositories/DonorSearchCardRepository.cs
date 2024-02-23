using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class DonorSearchCardRepository : IDonorSearchRepository
{
    public Task<DonorSearchCardModel> CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason, int bloodAmount, DateTime endDate,
        bool isUrgent)
    {
        throw new NotImplementedException();
    }
}