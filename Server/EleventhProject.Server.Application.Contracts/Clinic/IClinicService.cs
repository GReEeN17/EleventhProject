using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Application.Contracts.Clinic;

public interface IClinicService
{
    ClinicModel CreateClinic(CityModel city, string Title, string Address);

    ClinicModel GetClinicById(int clinicId);

    IEnumerable<ClinicModel> GetAllClinics();
}