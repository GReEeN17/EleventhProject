using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.Pet;

namespace EleventhProject.Server.Infrastructure.Entities.DonationHistory;

public class DonationHistoryEntity : Entity
{
    public PetEntity Recipient { get; set; }
    public PetEntity Donor { get; set; }
    public DateTime Date { get; set; }
}