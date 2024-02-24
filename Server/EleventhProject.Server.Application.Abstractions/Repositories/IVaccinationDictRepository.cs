using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IVaccinationDictRepository
{
    IQueryable<VaccinationDictModel> GetVaccinationDict(int vaccinationDictId);
    IQueryable<VaccinationDictModel> GetVaccinationDict();
    IQueryable<VaccinationDictModel> GetAllVaccinationDicts();
    
    Task<int> CreateVaccinationDict(VaccinationDictModel vaccinationDict);
    Task CreateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);

    Task DeleteVaccinationDict(int vaccinationDictId);

    Task RemoveVaccinationDict(VaccinationDictModel vaccinationDict);
    Task RemoveRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);

    Task UpdateVaccinationDict(VaccinationDictModel vaccinationDict);
    Task UpdateRangeVaccinationDicts(IEnumerable<VaccinationDictModel> vaccinationDicts);
    
    Task<int> SaveChangesAsync();
}