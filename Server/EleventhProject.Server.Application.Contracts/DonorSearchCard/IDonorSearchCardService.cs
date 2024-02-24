using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Contracts.DonorSearchCard;

public interface IDonorSearchCardService
{
    DonorSearchCardModel CreateDonorSearchCard(UserModel creator, ClinicModel clinic, string reason, int bloodAmount,
        DateTime endDate, bool isUrgent);

    DonorSearchCardModel GetDonorSearchCardById(int donorSearchCardId);

    IEnumerable<DonorSearchCardModel> GetDonorSearchCardsByCity(int cityId);
}