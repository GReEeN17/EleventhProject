using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.DonationHistory;

public interface IDonationHistoryService
{
    Task<IActionResult> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date);

    Task<IActionResult> GetDonationHistoryById(int donationHistoryId);

    IAsyncEnumerable<IActionResult> GetAllDonationHistory();
}