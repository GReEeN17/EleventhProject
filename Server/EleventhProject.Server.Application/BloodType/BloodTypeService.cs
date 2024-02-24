using System.Text.Json;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.BloodType;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Infrastructure.Entities.BloodType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.BloodType;

public class BloodTypeService : IBloodTypeService
{
    private readonly IBloodTypeRepository _bloodTypeRepository;
    private readonly IMapper _mapper;
    public Task<string> CreateBloodType(string title)
    {
        var entity = _mapper.Map<BloodTypeEntity>(new BloodTypeModel(title));
        var result = _bloodTypeRepository.CreateBloodType(entity);

        return Task.FromResult(JsonSerializer.Serialize(result));
    }

    public Task<string> GetBloodTypeById(int bloodTypeId)
    {
        var entity = _bloodTypeRepository.GetBloodType().Where(bloodType => bloodType.Id == bloodTypeId);
        var bloodTypeModel = _mapper.Map<BloodTypeModel>(entity);

        var response = new
        {
            title = bloodTypeModel.Title
        };
        
        return Task.FromResult((JsonSerializer.Serialize(response)));
    }

    public string GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }
}