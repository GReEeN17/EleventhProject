using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.BloodType;

public interface IBloodTypeService
{
    Task<string> CreateBloodType(string title);

    Task<string> GetBloodTypeById(int bloodTypeId);

    IAsyncEnumerable<string> GetAllBloodTypes();
}