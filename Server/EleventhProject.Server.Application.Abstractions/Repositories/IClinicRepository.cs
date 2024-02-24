using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IClinicRepository
{
    IQueryable<ClinicModel> GetClinic(int breedId);
    IQueryable<ClinicModel> GetClinic();
    IQueryable<ClinicModel> GetAllClinics();
    IQueryable<ClinicModel> GetAllClinics(int cityId);
    
    Task<int> CreateClinic(ClinicModel clinic);
    Task CreateRangeClinics(IEnumerable<ClinicModel> clinics);

    Task DeleteClinic(int clinicId);

    Task RemoveClinic(ClinicModel clinic);
    Task RemoveRangeClinics(IEnumerable<ClinicModel> clinics);

    Task UpdateClinic(ClinicModel clinic);
    Task UpdateRangeClinics(IEnumerable<ClinicModel> clinics);
    
    Task<int> SaveChangesAsync();
}