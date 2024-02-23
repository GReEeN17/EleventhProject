using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.Pet;

namespace EleventhProject.Server.Application.Models.DonationHistory;

public class DonationHistoryModel : Model
{
    public PetModel Recipient { get; set; }
    public PetModel Donor { get; set; }
    public DateTime Date { get; set; }
}