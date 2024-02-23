using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.Pet;

namespace EleventhProject.Server.Infrastructure.Entities.DonationHistory;

public class DonationHistoryEntity : Entity
{
    public int RecipientId { get; set; }
    public PetEntity Recipient { get; set; }
    public int DonorId { get; set; }
    public PetEntity Donor { get; set; }
    public DateTime Date { get; set; }
}