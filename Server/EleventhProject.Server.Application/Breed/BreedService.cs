using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleventhProject.Server.Application.Contracts.Breed;
using EleventhProject.Server.Application.Models.Breed;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Breed;

public class BreedService : IBreedService
{
    public Task<BreedModel> CreateBreed(string title)
    {
        throw new NotImplementedException();
    }

    public Task<BreedModel> GetBreedById(int breedId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<BreedModel> GetAllBreeds()
    {
        throw new NotImplementedException();
    }
}