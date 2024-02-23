using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class DonationHistoryRepository : IDonationHistoryRepository
{
    public Task<DonationHistoryModel> CreateDonationHistory(PetModel recipient, PetModel donor, DateTime date)
    {
        throw new NotImplementedException();
    }
}