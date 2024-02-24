using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonorSearchRepository
{
    IQueryable<DonationHistoryEntity> GetDonorSearchCard(int donorSearchCardId);
    IQueryable<DonationHistoryEntity> GetDonorSearchCard();
    IQueryable<DonationHistoryEntity> GetAllDonorSearchCards();
    
    Task<DonationHistoryEntity> CreateDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task CreateRangeDonorSearchCard(IEnumerable<DonorSearchCardModel> donorSearchCards);

    Task DeleteDonorSearchCard(int donorSearchCardId);

    Task RemoveDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task RemoveRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards);

    Task UpdateDonorSearchCard(DonorSearchCardModel donorSearchCard);
    Task UpdateRangeDonorSearchCards(IEnumerable<DonorSearchCardModel> donorSearchCards);
    
    Task<int> SaveChangesAsync();
}