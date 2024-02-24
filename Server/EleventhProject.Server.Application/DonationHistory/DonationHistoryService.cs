using EleventhProject.Server.Application.Contracts.DonationHistory;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.DonationHistory;

public class DonationHistoryService : IDonationHistoryService
{
    public Task<IActionResult> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetDonationHistoryById(int donationHistoryId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllDonationHistory()
    {
        throw new NotImplementedException();
    }
}