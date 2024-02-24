using EleventhProject.Server.Application.Models.PetVaccination;

namespace EleventhProject.Server.Application.Contracts.PetVaccination;

public interface IPetVaccinationService
{
    Task<PetVaccinationModel> CreatePetVaccination(int vaccinationId, int petId);

    Task<PetVaccinationModel> GetPetVaccinationById(int petVaccinationId);

    IAsyncEnumerable<PetVaccinationModel> GetAllPetVaccinations();
}