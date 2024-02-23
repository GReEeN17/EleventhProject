using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Models.DonorSearchCard;

namespace EleventhProject.Server.Application.DonorSearchCard;

public class DonorSearchCardService : IDonorSearchCardService
{
    public DonorSearchCardModel CreateDonorSearch(int creatorId, int clinicId, string reason, int bloodAmount, DateTime endDate,
        bool isUrgent)
    {
        throw new NotImplementedException();
    }
}