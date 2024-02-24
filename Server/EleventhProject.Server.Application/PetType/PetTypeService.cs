using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.PetType;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.PetType;

public class PetTypeService : IPetTypeService
{
    private readonly IPetTypeRepository _petTypeRepository;
    private readonly IMapper _mapper;

    public PetTypeService(
        IPetTypeRepository petTypeRepository,
        IMapper mapper)
    {
        _petTypeRepository = petTypeRepository;
        _mapper = mapper;
    }
    
    public async Task<string> CreatePetType(string title)
    {
        var model = new PetTypeModel
        {
            Title = title
        };

        var entity = _mapper.Map<PetTypeEntity>(model);

        var result = await _petTypeRepository.CreatePetType(entity);

        await _petTypeRepository.SaveChangesAsync();

        return JsonSerializer.Serialize(result.Id);
    }

    public Task<IActionResult> GetPetTypeById(int petTypeId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllPetTypes()
    {
        throw new NotImplementedException();
    }
}