using EleventhProject.Server.Application.Models.PetVaccination;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.PetVaccination;

public interface IPetVaccinationService
{
    Task<IActionResult> CreatePetVaccination(int vaccinationId, int petId);

    Task<IActionResult> GetPetVaccinationById(int petVaccinationId);

    IAsyncEnumerable<IActionResult> GetAllPetVaccinations();
}