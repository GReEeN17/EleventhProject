using EleventhProject.Server.Application.Models.DonorSearchCard;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonorSearchRepository
{
    IQueryable<DonorSearchCardModel> GetDonorSearchCard(int donorSearchCardId);
    IQueryable<DonorSearchCardModel> GetDonorSearchCard();
    IQueryable<DonorSearchCardModel> GetAllDonorSearchCards();
    
    Task<int> CreateDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task CreateRangeDonorSearchCard(IEnumerable<DonorSearchCardModel> donorSearchCards);

    Task DeleteDonorSearchCard(int donorSearchCardId);

    Task RemoveDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task RemoveRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards);

    Task UpdateDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task UpdateRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards);
    
    Task<int> SaveChangesAsync();
}