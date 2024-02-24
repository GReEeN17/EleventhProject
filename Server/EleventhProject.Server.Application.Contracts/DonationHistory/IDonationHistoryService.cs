using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Contracts.DonationHistory;

public interface IDonationHistoryService
{
    Task<DonationHistoryModel> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date);

    Task<DonationHistoryModel> GetDonationHistoryById(int donationHistoryId);

    IAsyncEnumerable<DonationHistoryModel> GetAllDonationHistory();
}