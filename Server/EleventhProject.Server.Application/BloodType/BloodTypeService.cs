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
    public Task<string> CreateBloodType(string title)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetBloodTypeById(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public string GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }
}