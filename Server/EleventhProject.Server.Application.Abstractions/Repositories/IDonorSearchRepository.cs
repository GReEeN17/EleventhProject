using System.Linq.Expressions;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IDonorSearchRepository
{
    IQueryable<DonorSearchCardEntity> GetDonorSearchCard(Expression<Func<DonorSearchCardEntity, bool>> selector);
    IQueryable<DonorSearchCardEntity> GetDonorSearchCard();
    IQueryable<DonorSearchCardEntity> GetAllDonorSearchCards();
    
    Task<DonorSearchCardEntity> CreateDonorSearchCard(DonorSearchCardEntity donorSearchCard);
    Task CreateRangeDonorSearchCard(IEnumerable<DonorSearchCardEntity> donorSearchCards);

    Task DeleteDonorSearchCard(int donorSearchCardId);

    Task RemoveDonorSearchCard(DonorSearchCardEntity donorSearchCard);
    Task RemoveRangeDonorSearchCards(IEnumerable<DonorSearchCardEntity> donorSearchCards);

    Task UpdateDonorSearchCard(DonorSearchCardEntity donorSearchCard);
    Task UpdateRangeDonorSearchCards(IEnumerable<DonorSearchCardEntity> donorSearchCards);
    
    Task<int> SaveChangesAsync();
}