using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.PetVaccination;
using EleventhProject.Server.Application.Models.PetVaccination;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.PetVaccination;

public class PetVaccinationService : IPetVaccinationService
{
    public Task<PetVaccinationModel> CreatePetVaccination(int vaccinationId, int petId)
    {
        throw new NotImplementedException();
    }

    public Task<PetVaccinationModel> GetPetVaccinationById(int petVaccinationId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<PetVaccinationModel> GetAllPetVaccinations()
    {
        throw new NotImplementedException();
    }
}