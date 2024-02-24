using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Infrastructure.Entities.Clinic;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IClinicRepository
{
    IQueryable<ClinicEntity> GetClinic(int breedId);
    IQueryable<ClinicEntity> GetClinic();
    IQueryable<ClinicEntity> GetAllClinics();
    IQueryable<ClinicEntity> GetAllClinics(int cityId);
    
    Task<ClinicEntity> CreateClinic(ClinicEntity clinic);
    Task CreateRangeClinics(IEnumerable<ClinicEntity> clinics);

    Task DeleteClinic(int clinicId);

    Task RemoveClinic(ClinicEntity clinic);
    Task RemoveRangeClinics(IEnumerable<ClinicEntity> clinics);

    Task UpdateClinic(ClinicEntity clinic);
    Task UpdateRangeClinics(IEnumerable<ClinicEntity> clinics);
    
    Task<int> SaveChangesAsync();
}