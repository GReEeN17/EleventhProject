using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IUserRepository
{
    IQueryable<UserEntity> GetUser(int userId);
    IQueryable<UserEntity> GetUser();
    IQueryable<UserEntity> GetAllUsers();
    
    Task<UserEntity> CreateUser(UserModel user);
    Task CreateRangeUsers(IEnumerable<UserModel> users);

    Task DeleteUser(int userId);

    Task RemoveUser(UserModel user);
    Task RemoveRangeUsers(IEnumerable<UserModel> users);

    Task UpdateUser(UserModel user);
    Task UpdateRangeUsers(IEnumerable<UserModel> users);
    
    Task<int> SaveChangesAsync();
}