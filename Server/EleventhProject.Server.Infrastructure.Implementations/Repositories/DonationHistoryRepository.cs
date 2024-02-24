using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using Microsoft.EntityFrameworkCore;

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
        return _context.Set<DonationHistoryEntity>().Where(x => x.Id == donationHistoryId).Where(x => x.IsActive)
            .AsQueryable();
    }

    public IQueryable<DonationHistoryEntity> GetDonationHistory()
    {
        return _context.Set<DonationHistoryEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<DonationHistoryEntity> GetAllDonationHistories()
    {
        return _context.Set<DonationHistoryEntity>().AsQueryable();
    }

    public async Task<DonationHistoryEntity> CreateDonationHistory(DonationHistoryEntity donationHistory)
    {
        var entitiy = await _context.Set<DonationHistoryEntity>().AddAsync(donationHistory);
        return entitiy.Entity;
    }

    public async Task CreateRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories)
    {
        await _context.Set<DonationHistoryEntity>().AddRangeAsync(donationHistories);
    }

    public async Task DeleteDonationHistory(int donationHistoryId)
    {
        var activeEntity = await _context.Set<DonationHistoryEntity>().FirstOrDefaultAsync(x => x.Id == donationHistoryId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveDonationHistory(DonationHistoryEntity donationHistory)
    {
        await Task.Run(() => _context.Set<DonationHistoryEntity>().Remove(donationHistory));
    }

    public async Task RemoveRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories)
    {
        await Task.Run(() => _context.Set<DonationHistoryEntity>().RemoveRange(donationHistories));
    }

    public async Task UpdateDonationHistory(DonationHistoryEntity donationHistory)
    {
        await Task.Run(() => _context.Set<DonationHistoryEntity>().Update(donationHistory));
    }

    public async Task UpdateRangeDonationHistories(IEnumerable<DonationHistoryEntity> donationHistories)
    {
        await Task.Run(() => _context.Set<DonationHistoryEntity>().UpdateRange(donationHistories));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}