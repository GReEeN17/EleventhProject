using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Models.DonorSearchCard;

public class DonorSearchCardModel : Model
{
    public UserModel Creator { get; set; }
    public ClinicModel Clinic { get; set; }
    public string Reason { get; set; }
    public int BloodAmount { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsUrgent { get; set; }
    public int PetsCurrent { get; set; }
    public int PetsNeeded { get; set; }
}