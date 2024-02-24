using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class ClinicRepository : IClinicRepository
{
    private readonly DataContext.DataContext _context;

    public ClinicRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<ClinicModel> GetClinic(int breedId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicModel> GetClinic()
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicModel> GetAllClinics()
    {
        throw new NotImplementedException();
    }

    public IQueryable<ClinicModel> GetAllClinics(int cityId)
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateClinic(ClinicModel clinic)
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