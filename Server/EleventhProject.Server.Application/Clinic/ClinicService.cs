using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.Clinic;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Clinic;

public class ClinicService : IClinicService
{
    public Task<ClinicModel> CreateClinic(CityModel city, string Title, string Address)
    {
        throw new NotImplementedException();
    }

    public Task<ClinicModel> GetClinicById(int clinicId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<ClinicModel> GetAllClinics(int? cityId)
    {
        throw new NotImplementedException();
    }
}