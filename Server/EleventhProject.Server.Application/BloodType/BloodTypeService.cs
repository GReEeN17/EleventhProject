using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.BloodType;
using EleventhProject.Server.Application.Models.BloodType;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.BloodType;

public class BloodTypeService : IBloodTypeService
{
    private readonly IBloodTypeRepository _bloodTypeRepository;
    public Task<IActionResult> CreateBloodType(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetBloodTypeById(int bloodTypeId)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllBloodTypes()
    {
        throw new NotImplementedException();
    }
}