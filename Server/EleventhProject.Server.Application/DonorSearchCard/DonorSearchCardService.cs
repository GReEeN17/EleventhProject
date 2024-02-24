using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.DonorSearchCard;

public class DonorSearchCardService : IDonorSearchCardService
{
    public Task<DonorSearchCardModel> CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason, int bloodAmount,
        DateTime endDate, bool isUrgent)
    {
        throw new NotImplementedException();
    }

    public Task<DonorSearchCardModel> GetDonorSearchCardById(int donorSearchCardId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<DonorSearchCardModel> GetDonorSearchCardsByCity(int cityId)
    {
        throw new NotImplementedException();
    }
}