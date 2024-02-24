using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Infrastructure.Entities.Clinic;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IClinicRepository
{
    IQueryable<ClinicEntity> GetClinic(int breedId);
    IQueryable<ClinicEntity> GetClinic();
    IQueryable<ClinicEntity> GetAllClinics();
    IQueryable<ClinicEntity> GetAllClinics(int cityId);
    
    Task<ClinicEntity> CreateClinic(ClinicModel clinic);
    Task CreateRangeClinics(IEnumerable<ClinicModel> clinics);

    Task DeleteClinic(int clinicId);

    Task RemoveClinic(ClinicModel clinic);
    Task RemoveRangeClinics(IEnumerable<ClinicModel> clinics);

    Task UpdateClinic(ClinicModel clinic);
    Task UpdateRangeClinics(IEnumerable<ClinicModel> clinics);
    
    Task<int> SaveChangesAsync();
}