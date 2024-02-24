using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IVaccinationDictRepository
{
    IQueryable<VaccinationDictEntity> GetVaccinationDict(int vaccinationDictId);
    IQueryable<VaccinationDictEntity> GetVaccinationDict();
    IQueryable<VaccinationDictEntity> GetAllVaccinationDicts();
    
    Task<VaccinationDictEntity> CreateVaccinationDict(VaccinationDictModel vaccinationDict);
    Task CreateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);

    Task DeleteVaccinationDict(int vaccinationDictId);

    Task RemoveVaccinationDict(VaccinationDictModel vaccinationDict);
    Task RemoveRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);

    Task UpdateVaccinationDict(VaccinationDictModel vaccinationDict);
    Task UpdateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);
    
    Task<int> SaveChangesAsync();
}