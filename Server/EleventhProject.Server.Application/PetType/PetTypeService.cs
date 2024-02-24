using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.PetType;
using EleventhProject.Server.Application.Models.PetType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.PetType;

public class PetTypeService : IPetTypeService
{
    public Task<PetTypeModel> CreatePetType(string title)
    {
        throw new NotImplementedException();
    }

    public Task<PetTypeModel> GetPetTypeById(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<PetTypeModel> GetAllPetTypes()
    {
        throw new NotImplementedException();
    }
}