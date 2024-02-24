using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.DonorSearchCard;

public class DonorSearchCardService : IDonorSearchCardService
{
    public DonorSearchCardModel CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason, int bloodAmount,
        DateTime endDate, bool isUrgent)
    {
        throw new NotImplementedException();
    }

    public DonorSearchCardModel GetDonorSearchCardById(int donorSearchCardId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DonorSearchCardModel> GetDonorSearchCardsByCity(int cityId)
    {
        throw new NotImplementedException();
    }
}