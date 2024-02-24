using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.User;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DataContext.DataContext _context;

    public UserRepository(DataContext.DataContext context)
    {
        _context = context;
    }
    public IQueryable<UserEntity> GetUser(int userId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserEntity> GetUser()
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserEntity> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity> CreateUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task CreateRangeUsers(IEnumerable<UserModel> users)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRangeUsers(IEnumerable<UserModel> users)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeUsers(IEnumerable<UserModel> users)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}