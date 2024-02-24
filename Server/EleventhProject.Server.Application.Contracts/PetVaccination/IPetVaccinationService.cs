using EleventhProject.Server.Application.Models.PetVaccination;

namespace EleventhProject.Server.Application.Contracts.PetVaccination;

public interface IPetVaccinationService
{
    PetVaccinationModel CreatePetVaccination(int vaccinationId, int petId);

    PetVaccinationModel GetPetVaccinationById(int petVaccinationId);

    IEnumerable<PetVaccinationModel> GetAllPetVaccinations();
}