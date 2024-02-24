using EleventhProject.Server.Application.Models.VaccinationDict;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.VaccinationDict;

public interface IVaccinationDictService
{
    Task<IActionResult> CreateVaccinationDict(string title);

    Task<IActionResult> GetVaccinationDictById(int vaccinationDictId);

    IAsyncEnumerable<IActionResult> GetAllVaccinations();
}