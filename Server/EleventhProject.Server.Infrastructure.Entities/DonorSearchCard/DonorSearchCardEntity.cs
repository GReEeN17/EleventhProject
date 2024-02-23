using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.Clinic;

namespace EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;

public class DonorSearchCardEntity : Entity
{
    public int CreatorId { get; set; }
    public int ClinicId { get; set; }
    public ClinicEntity Clinic { get; set; }
    public string Reason { get; set; }
    public int BloodAmount { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsUrgent { get; set; }
}