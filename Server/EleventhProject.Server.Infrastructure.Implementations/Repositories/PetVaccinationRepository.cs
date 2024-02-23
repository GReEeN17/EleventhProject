using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetVaccinationRepository : IPetVaccinationRepository
{
    public Task<PetVaccinationModel> CreatePetVaccination(VaccinationDictModel vaccinationDict)
    {
        throw new NotImplementedException();
    }
}