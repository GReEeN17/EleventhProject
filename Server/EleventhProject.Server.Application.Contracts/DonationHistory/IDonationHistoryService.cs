using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Contracts.DonationHistory;

public interface IDonationHistoryService
{
    DonationHistoryModel CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date);

    DonationHistoryModel GetDonationHistoryById(int donationHistoryId);

    IEnumerable<DonationHistoryModel> GetAllDonationHistory();
}