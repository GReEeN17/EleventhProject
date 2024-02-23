using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Contracts.VaccinationDict;

public interface IVaccinationDictService
{
    VaccinationDictModel CreateVaccinationDict(string title);

    VaccinationDictModel GetVaccinationDictById(int vaccinationDictId);
}