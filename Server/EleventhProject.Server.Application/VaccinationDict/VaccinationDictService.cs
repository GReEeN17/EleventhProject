using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.VaccinationDict;
using EleventhProject.Server.Application.Models.VaccinationDict;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.VaccinationDict;

public class VaccinationDictService : IVaccinationDictService
{
    public Task<VaccinationDictModel> CreateVaccinationDict(string title)
    {
        throw new NotImplementedException();
    }

    public Task<VaccinationDictModel> GetVaccinationDictById(int vaccinationDictId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<VaccinationDictModel> GetAllVaccinations()
    {
        throw new NotImplementedException();
    }
}