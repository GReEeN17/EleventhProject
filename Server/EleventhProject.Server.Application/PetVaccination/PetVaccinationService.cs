using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.PetVaccination;
using EleventhProject.Server.Application.Models.PetVaccination;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.PetVaccination;

public class PetVaccinationService : IPetVaccinationService
{
    public Task<IActionResult> CreatePetVaccination(int vaccinationId, int petId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetPetVaccinationById(int petVaccinationId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllPetVaccinations()
    {
        throw new NotImplementedException();
    }
}