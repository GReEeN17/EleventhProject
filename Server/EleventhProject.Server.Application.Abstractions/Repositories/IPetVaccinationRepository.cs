using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IPetVaccinationRepository
{
    IQueryable<PetVaccinationEntity> GetPetVaccination(int petVaccinationId);
    IQueryable<PetVaccinationEntity> GetPetVaccination();
    IQueryable<PetVaccinationEntity> GetAllPetVaccinations();
    
    Task<PetVaccinationEntity> CreatePetVaccination(PetVaccinationEntity petVaccination);
    Task CreateRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations);

    Task DeletePetVaccination(int petVaccinationId);

    Task RemovePetVaccination(PetVaccinationEntity petVaccination);
    Task RemoveRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations);

    Task UpdatePetVaccination(PetVaccinationEntity petVaccination);
    Task UpdateRangePetVaccinations(IEnumerable<PetVaccinationEntity> petVaccinations);
    
    Task<int> SaveChangesAsync();
}