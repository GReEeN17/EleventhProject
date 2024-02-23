using EleventhProject.Server.Application.Contracts.DonationHistory;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.DonationHistory;

public class DonationHistoryService : IDonationHistoryService
{
    public DonationHistoryModel CreateDonationHistory(int recipientId, int donorId)
    {
        throw new NotImplementedException();
    }

    public DonationHistoryModel CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date)
    {
        throw new NotImplementedException();
    }

    public DonationHistoryModel GetDonationHistoryById(int donationHistoryId)
    {
        throw new NotImplementedException();
    }
}