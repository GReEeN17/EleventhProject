using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonationHistoryRepository
{
    IQueryable<DonationHistoryEntity> GetDonationHistory(int donationHistoryId);
    IQueryable<DonationHistoryEntity> GetDonationHistory();
    IQueryable<DonationHistoryEntity> GetAllDonationHistories();
    
    Task<DonationHistoryEntity> CreateDonationHistory(DonationHistoryModel donationHistory);
    Task CreateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);

    Task DeleteDonationHistory(int donationHistoryId);

    Task RemoveDonationHistory(DonationHistoryModel donationHistory);
    Task RemoveRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);

    Task UpdateDonationHistory(DonationHistoryModel donationHistory);
    Task UpdateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);
    
    Task<int> SaveChangesAsync();
}