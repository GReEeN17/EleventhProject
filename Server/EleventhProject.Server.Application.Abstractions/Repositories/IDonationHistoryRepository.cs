using EleventhProject.Server.Application.Models.DonationHistory;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonationHistoryRepository
{
    IQueryable<DonationHistoryModel> GetDonationHistory(int donationHistoryId);
    IQueryable<DonationHistoryModel> GetDonationHistory();
    IQueryable<DonationHistoryModel> GetAllDonationHistories();
    
    Task<int> CreateDonationHistory(DonationHistoryModel donationHistory);
    Task CreateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);

    Task DeleteDonationHistory(int donationHistoryId);

    Task RemoveDonationHistory(DonationHistoryModel donationHistory);
    Task RemoveRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);

    Task UpdateDonationHistory(DonationHistoryModel donationHistory);
    Task UpdateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories);
    
    Task<int> SaveChangesAsync();
}