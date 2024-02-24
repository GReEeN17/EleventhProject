using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Contracts.BloodType;

public interface IBloodTypeService
{
    Task<IActionResult> CreateBloodType(string title);

    Task<IActionResult> GetBloodTypeById(int bloodTypeId);

    IAsyncEnumerable<IActionResult> GetAllBloodTypes();
}