using EleventhProject.Server.Application.Models.DonorSearchCard;

namespace EleventhProject.Server.Application.Contracts.DonorSearchCard;

public interface IDonorSearchCardService
{
    DonorSearchCardModel CreateDonorSearch(int creatorId, int clinicId, string reason, int bloodAmount,
        DateTime endDate, bool isUrgent);
}