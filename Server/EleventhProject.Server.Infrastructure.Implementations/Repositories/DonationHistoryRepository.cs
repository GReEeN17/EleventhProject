using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class DonationHistoryRepository : IDonationHistoryRepository
{
    private readonly DataContext.DataContext _context;

    public DonationHistoryRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<DonationHistoryEntity> GetDonationHistory(int donationHistoryId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<DonationHistoryEntity> GetDonationHistory()
    {
        throw new NotImplementedException();
    }

    public IQueryable<DonationHistoryEntity> GetAllDonationHistories()
    {
        throw new NotImplementedException();
    }

    public Task<DonationHistoryEntity> CreateDonationHistory(DonationHistoryModel donationHistory)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDonationHistory(int donationHistoryId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveDonationHistory(DonationHistoryModel donationHistory)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDonationHistory(DonationHistoryModel donationHistory)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeDonationHistories(IEnumerable<DonationHistoryModel> donationHistories)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}