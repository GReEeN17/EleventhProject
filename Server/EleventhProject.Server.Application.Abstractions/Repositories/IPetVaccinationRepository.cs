using EleventhProject.Server.Application.Models.PetVaccination;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetVaccinationRepository
{
    IQueryable<PetVaccinationModel> GetPetVaccination(int petVaccinationId);
    IQueryable<PetVaccinationModel> GetPetVaccination();
    IQueryable<PetVaccinationModel> GetAllPetVaccinations();
    
    Task<int> CreatePetVaccination(PetVaccinationModel petVaccination);
    Task CreateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);

    Task DeletePetVaccination(int petVaccinationId);

    Task RemovePetVaccination(PetVaccinationModel petVaccination);
    Task RemoveRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);

    Task UpdatePetVaccination(PetVaccinationModel petVaccination);
    Task UpdateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);
    
    Task<int> SaveChangesAsync();
}