using System.Linq.Expressions;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IVaccinationDictRepository
{
    IQueryable<VaccinationDictEntity> GetVaccinationDict(Expression<Func<VaccinationDictEntity, bool>> selector);
    IQueryable<VaccinationDictEntity> GetVaccinationDict();
    IQueryable<VaccinationDictEntity> GetAllVaccinationDicts();
    
    Task<VaccinationDictEntity> CreateVaccinationDict(VaccinationDictEntity vaccinationDict);
    Task CreateRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts);

    Task DeleteVaccinationDict(int vaccinationDictId);

    Task RemoveVaccinationDict(VaccinationDictEntity vaccinationDict);
    Task RemoveRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts);

    Task UpdateVaccinationDict(VaccinationDictEntity vaccinationDict);
    Task UpdateRangeVaccinationDicts(IEnumerable<VaccinationDictEntity> vaccinationDicts);
    
    Task<int> SaveChangesAsync();
}