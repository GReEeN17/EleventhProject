using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IUserRepository
{
    IQueryable<UserEntity> GetUser(int userId);
    IQueryable<UserEntity> GetUser();
    IQueryable<UserEntity> GetAllUsers();
    
    Task<UserEntity> CreateUser(UserEntity user);
    Task CreateRangeUsers(IEnumerable<UserEntity> users);

    Task DeleteUser(int userId);

    Task RemoveUser(UserEntity user);
    Task RemoveRangeUsers(IEnumerable<UserEntity> users);

    Task UpdateUser(UserEntity user);
    Task UpdateRangeUsers(IEnumerable<UserEntity> users);
    
    Task<int> SaveChangesAsync();
}