using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.Clinic;

public interface IClinicService
{
    Task<IActionResult> CreateClinic(CityModel city, string Title, string Address);

    Task<IActionResult> GetClinicById(int clinicId);

    IAsyncEnumerable<IActionResult> GetAllClinics(int? cityId);
}