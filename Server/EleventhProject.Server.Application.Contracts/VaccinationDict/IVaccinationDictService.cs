using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Contracts.VaccinationDict;

public interface IVaccinationDictService
{
    Task<VaccinationDictModel> CreateVaccinationDict(string title);

    Task<VaccinationDictModel> GetVaccinationDictById(int vaccinationDictId);

    IAsyncEnumerable<VaccinationDictModel> GetAllVaccinations();
}