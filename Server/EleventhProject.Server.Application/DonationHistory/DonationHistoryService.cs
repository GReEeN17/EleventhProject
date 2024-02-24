using EleventhProject.Server.Application.Contracts.DonationHistory;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.DonationHistory;

public class DonationHistoryService : IDonationHistoryService
{
    public Task<DonationHistoryModel> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date)
    {
        throw new NotImplementedException();
    }

    public Task<DonationHistoryModel> GetDonationHistoryById(int donationHistoryId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<DonationHistoryModel> GetAllDonationHistory()
    {
        throw new NotImplementedException();
    }
}