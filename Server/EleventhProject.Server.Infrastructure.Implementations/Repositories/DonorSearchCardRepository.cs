using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class DonorSearchCardRepository : IDonorSearchRepository
{
    private readonly DataContext.DataContext _context;

    public DonorSearchCardRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<DonorSearchCardModel> GetDonorSearchCard(int donorSearchCardId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<DonorSearchCardModel> GetDonorSearchCard()
    {
        throw new NotImplementedException();
    }

    public IQueryable<DonorSearchCardModel> GetAllDonorSearchCards()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateDonorSearchCard(DonorSearchCardModel donorSearchCard)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeDonorSearchCard(IEnumerable<DonorSearchCardModel> donorSearchCards)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDonorSearchCard(int donorSearchCardId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveDonorSearchCard(DonorSearchCardModel donorSearchCard)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDonorSearchCard(DonorSearchCardModel donorSearchCard)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}