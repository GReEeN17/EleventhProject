using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonationHistoryRepository
{
    Task<DonationHistoryModel> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date);
}