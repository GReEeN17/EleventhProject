using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.User;
using Microsoft.EntityFrameworkCore;

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
        return _context.Set<UserEntity>().Where(x => x.Id == userId).Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<UserEntity> GetUser()
    {
        return _context.Set<UserEntity>().Where(x => x.IsActive).AsQueryable();
    }

    public IQueryable<UserEntity> GetAllUsers()
    {
        return _context.Set<UserEntity>().AsQueryable();
    }

    public async Task<UserEntity> CreateUser(UserEntity user)
    {
        var entitiy = await _context.Set<UserEntity>().AddAsync(user);
        return entitiy.Entity;
    }

    public async Task CreateRangeUsers(IEnumerable<UserEntity> users)
    {
        await _context.Set<UserEntity>().AddRangeAsync(users);
    }

    public async Task DeleteUser(int userId)
    {
        var activeEntity = await _context.Set<UserEntity>().FirstOrDefaultAsync(x => x.Id == userId);
        activeEntity.IsActive = false;
        await Task.Run(() => _context.Update(activeEntity));
    }

    public async Task RemoveUser(UserEntity user)
    {
        await Task.Run(() => _context.Set<UserEntity>().Remove(user));
    }

    public async Task RemoveRangeUsers(IEnumerable<UserEntity> users)
    {
        await Task.Run(() => _context.Set<UserEntity>().RemoveRange(users));
    }

    public async Task UpdateUser(UserEntity user)
    {
        await Task.Run(() => _context.Set<UserEntity>().Update(user));
    }

    public async Task UpdateRangeUsers(IEnumerable<UserEntity> users)
    {
        await Task.Run(() => _context.Set<UserEntity>().UpdateRange(users));
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}