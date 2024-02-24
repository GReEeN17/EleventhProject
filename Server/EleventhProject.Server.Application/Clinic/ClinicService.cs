using EleventhProject.Server.Application.Contracts.Clinic;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Clinic;

public class ClinicService : IClinicService
{
    public Task<IActionResult> CreateClinic(CityModel city, string Title, string Address)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetClinicById(int clinicId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllClinics(int? cityId)
    {
        throw new NotImplementedException();
    }
}