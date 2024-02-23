using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IClinicRepository
{
    Task<ClinicModel> CreateClinic(string title, string address, ClinicModel city);
}