using EleventhProject.Server.Application.Models.DonationHistory;

namespace EleventhProject.Server.Application.Contracts.DonationHistory;

public interface IDonationHistoryService
{
    DonationHistoryModel CreateDonationHistory(int recipientId, int donorId);
}