using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetVaccinationRepository : IPetVaccinationRepository
{
    private readonly DataContext.DataContext _context;

    public PetVaccinationRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetVaccinationEntity> GetPetVaccination(int petVaccinationId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetVaccinationEntity> GetPetVaccination()
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetVaccinationEntity> GetAllPetVaccinations()
    {
        throw new NotImplementedException();
    }

    public Task<PetVaccinationEntity> CreatePetVaccination(PetVaccinationModel petVaccination)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations)
    {
        throw new NotImplementedException();
    }

    public Task DeletePetVaccination(int petVaccinationId)
    {
        throw new NotImplementedException();
    }

    public Task RemovePetVaccination(PetVaccinationModel petVaccination)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePetVaccination(PetVaccinationModel petVaccination)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangePetVaccinations(IEnumerable<PetVaccinationModel> petVaccinations)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}