using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class DonorSearchCardRepository : IDonorSearchRepository
{
    private readonly DataContext.DataContext _context;

    public DonorSearchCardRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<DonorSearchCardEntity> GetDonorSearchCard(int donorSearchCardId)
    {
        return _context.Set<DonorSearchCardEntity>().Where(x => x.Id == donorSearchCardId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<DonorSearchCardEntity> GetDonorSearchCard()
    {
        return _context.Set<DonorSearchCardEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<DonorSearchCardEntity> GetAllDonorSearchCards()
    {
        return _context.Set<DonorSearchCardEntity>().AsQueryable();
    }

    public async Task<DonorSearchCardEntity> CreateDonorSearchCard(DonorSearchCardEntity donorSearchCard)
    {
        var entitiy = await _context.Set<DonorSearchCardEntity>().AddAsync(donorSearchCard);
        return entitiy.Entity;
    }

    public async Task CreateRangeDonorSearchCard(IEnumerable<DonorSearchCardEntity> donorSearchCards)
    {
        await _context.Set<DonorSearchCardEntity>().AddRangeAsync(donorSearchCards);
    }

    public async Task DeleteDonorSearchCard(int donorSearchCardId)
    {
        var activeEntity = await _context.Set<DonorSearchCardEntity>().FirstOrDefaultAsync(x => x.Id == donorSearchCardId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveDonorSearchCard(DonorSearchCardEntity donorSearchCard)
    {
        await Task.Run(() => _context.Set<DonorSearchCardEntity>().Remove(donorSearchCard));
    }

    public async Task RemoveRangeDonorSearchCards(IEnumerable<DonorSearchCardEntity> donorSearchCards)
    {
        await Task.Run(() => _context.Set<DonorSearchCardEntity>().RemoveRange(donorSearchCards));
    }

    public async Task UpdateDonorSearchCard(DonorSearchCardEntity donorSearchCard)
    {
        await Task.Run(() => _context.Set<DonorSearchCardEntity>().Update(donorSearchCard));
    }

    public async Task UpdateRangeDonorSearchCards(IEnumerable<DonorSearchCardEntity> donorSearchCards)
    {
        await Task.Run(() => _context.Set<DonorSearchCardEntity>().UpdateRange(donorSearchCards));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}