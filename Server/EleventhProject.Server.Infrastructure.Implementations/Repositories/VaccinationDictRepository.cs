using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class VaccinationDictRepository : IVaccinationDictRepository
{
    private readonly DataContext.DataContext _context;

    public VaccinationDictRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<VaccinationDictEntity> GetVaccinationDict(int vaccinationDictId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<VaccinationDictEntity> GetVaccinationDict()
    {
        throw new NotImplementedException();
    }

    public IQueryable<VaccinationDictEntity> GetAllVaccinationDicts()
    {
        throw new NotImplementedException();
    }

    public Task<VaccinationDictEntity> CreateVaccinationDict(VaccinationDictModel vaccinationDict)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts)
    {
        throw new NotImplementedException();
    }

    public Task DeleteVaccinationDict(int vaccinationDictId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveVaccinationDict(VaccinationDictModel vaccinationDict)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts)
    {
        throw new NotImplementedException();
    }

    public Task UpdateVaccinationDict(VaccinationDictModel vaccinationDict)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}