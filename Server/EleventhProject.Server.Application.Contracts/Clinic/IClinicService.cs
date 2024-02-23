using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Application.Contracts.Clinic;

public interface IClinicService
{
    ClinicModel CreateClinic(int cityId, string Title, string Address);
}