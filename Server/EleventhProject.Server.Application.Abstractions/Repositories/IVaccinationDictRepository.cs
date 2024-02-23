using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IVaccinationDictRepository
{
    Task<VaccinationDictModel> CreateVaccinationDict(string title);
}