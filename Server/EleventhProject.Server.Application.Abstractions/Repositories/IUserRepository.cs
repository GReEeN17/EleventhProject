using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Abstractions.Repositories;

public interface IUserRepository
{
    IQueryable<UserModel> GetUser(int userId);
    IQueryable<UserModel> GetUser();
    IQueryable<UserModel> GetAllUsers();
    
    Task<int> CreateUser(UserModel user);
    Task CreateRangeUsers(IEnumerable<UserModel> users);

    Task DeleteUser(int userId);

    Task RemoveUser(UserModel user);
    Task RemoveRangeUsers(IEnumerable<UserModel> users);

    Task UpdateUser(UserModel user);
    Task UpdateRangeUsers(IEnumerable<UserModel> users);
    
    Task<int> SaveChangesAsync();
}