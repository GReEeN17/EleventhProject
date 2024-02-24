using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonationHistoryRepository
{
    IQueryable<DonationHistoryEntity> GetDonationHistory(int donationHistoryId);
    IQueryable<DonationHistoryEntity> GetDonationHistory();
    IQueryable<DonationHistoryEntity> GetAllDonationHistories();
    
    Task<DonationHistoryEntity> CreateDonationHistory(DonationHistoryEntity donationHistory);
    Task CreateRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories);

    Task DeleteDonationHistory(int donationHistoryId);

    Task RemoveDonationHistory(DonationHistoryEntity donationHistory);
    Task RemoveRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories);

    Task UpdateDonationHistory(DonationHistoryEntity donationHistory);
    Task UpdateRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories);
    
    Task<int> SaveChangesAsync();
}