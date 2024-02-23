using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class VaccinationDictRepository : IVaccinationDictRepository
{
    public Task<VaccinationDictModel> CreateVaccinationDict(string title)
    {
        throw new NotImplementedException();
    }
}