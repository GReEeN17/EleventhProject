using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetVaccinationRepository
{
    IQueryable<PetVaccinationEntity> GetPetVaccination(int petVaccinationId);
    IQueryable<PetVaccinationEntity> GetPetVaccination();
    IQueryable<PetVaccinationEntity> GetAllPetVaccinations();
    
    Task<PetVaccinationEntity> CreatePetVaccination(PetVaccinationModel petVaccination);
    Task CreateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);

    Task DeletePetVaccination(int petVaccinationId);

    Task RemovePetVaccination(PetVaccinationModel petVaccination);
    Task RemoveRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);

    Task UpdatePetVaccination(PetVaccinationModel petVaccination);
    Task UpdateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations);
    
    Task<int> SaveChangesAsync();
}