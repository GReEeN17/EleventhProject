using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.BloodType;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.User;
using EleventhProject.Server.Infrastructure.Entities.BloodType;

namespace EleventhProject.Server.Application.BloodType;

public class BloodTypeService : IBloodTypeService
{
    private readonly IBloodTypeRepository _bloodTypeRepository;
    private readonly IMapper _mapper;
    public Task<BloodTypeModel> CreateBloodType(string title)
    {
        var entity = _bloodTypeRepository.CreateBloodType(new BloodTypeEntity(title));

        var model = _mapper.Map<BloodTypeModel>(entity);
        return Task.FromResult(model);
    }

    public Task<BloodTypeModel> GetBloodTypeById(int bloodTypeId)
    {
    }

    public IAsyncEnumerable<BloodTypeModel> GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }
}