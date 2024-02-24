using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class PetRepository : IPetRepository
{
    private readonly DataContext.DataContext _context;

    public PetRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<PetModel> GetPet(int petId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetModel> GetPet()
    {
        throw new NotImplementedException();
    }

    public IQueryable<PetModel> GetAllPets()
    {
        throw new NotImplementedException();
    }

    public Task<int> CreatePet(PetModel pet)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangePets(IEnumerable<PetModel> pets)
    {
        throw new NotImplementedException();
    }

    public Task DeletePet(int petId)
    {
        throw new NotImplementedException();
    }

    public Task RemovePet(PetModel pet)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangePets(IEnumerable<PetModel> pets)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePet(PetModel pet)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangePets(IEnumerable<PetModel> pets)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}