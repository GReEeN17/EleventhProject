using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetVaccinationRepository
{
    Task<PetVaccinationModel> CreatePetVaccination(VaccinationDictModel vaccinationDict);
}