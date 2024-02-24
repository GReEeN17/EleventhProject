using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.VaccinationDict;
using EleventhProject.Server.Application.Models.VaccinationDict;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.VaccinationDict;

public class VaccinationDictService : IVaccinationDictService
{
    public Task<IActionResult> CreateVaccinationDict(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetVaccinationDictById(int vaccinationDictId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllVaccinations()
    {
        throw new NotImplementedException();
    }
}