using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.Clinic;

public interface IClinicService
{
    Task<ClinicModel> CreateClinic(CityModel city, string Title, string Address);

    Task<ClinicModel> GetClinicById(int clinicId);

    IAsyncEnumerable<ClinicModel> GetAllClinics(int? cityId);
}