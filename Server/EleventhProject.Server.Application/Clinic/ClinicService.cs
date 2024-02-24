using EleventhProject.Server.Application.Contracts.Clinic;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Application.Clinic;

public class ClinicService : IClinicService
{
    public ClinicModel CreateClinic(CityModel city, string Title, string Address)
    {
        throw new NotImplementedException();
    }

    public ClinicModel GetClinicById(int clinicId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ClinicModel> GetAllClinics(int? cityId)
    {
        throw new NotImplementedException();
    }
}