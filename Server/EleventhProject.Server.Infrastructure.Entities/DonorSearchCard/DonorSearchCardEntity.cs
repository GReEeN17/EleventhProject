using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.Clinic;
using EleventhProject.Server.Infrastructure.Entities.User;

namespace EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;

public class DonorSearchCardEntity : Entity
{
    public UserEntity Creator { get; set; }
    public ClinicEntity Clinic { get; set; }
    public string Reason { get; set; }
    public int BloodAmount { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsUrgent { get; set; }
}