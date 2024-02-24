using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Infrastructure.Entities.Clinic;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class ClinicRepository : IClinicRepository
{
    private readonly DataContext.DataContext _context;

    public ClinicRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<ClinicEntity> GetClinic(int breedId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicEntity> GetClinic()
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicEntity> GetAllClinics()
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicEntity> GetAllClinics(int cityId)
    {
        throw new NotImplementedException();
    }

    public Task<ClinicEntity> CreateClinic(ClinicModel clinic)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeClinics(IEnumerable<ClinicModel> clinics)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClinic(int clinicId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveClinic(ClinicModel clinic)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeClinics(IEnumerable<ClinicModel> clinics)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClinic(ClinicModel clinic)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeClinics(IEnumerable<ClinicModel> clinics)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}