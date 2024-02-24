using EleventhProject.Server.Application.Contracts.PetVaccination;
using EleventhProject.Server.Application.Models.PetVaccination;

namespace EleventhProject.Server.Application.PetVaccination;

public class PetVaccinationService : IPetVaccinationService
{
    public PetVaccinationModel CreatePetVaccination(int vaccinationId, int petId)
    {
        throw new NotImplementedException();
    }

    public PetVaccinationModel GetPetVaccinationById(int petVaccinationId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PetVaccinationModel> GetAllPetVaccinations()
    {
        throw new NotImplementedException();
    }
}