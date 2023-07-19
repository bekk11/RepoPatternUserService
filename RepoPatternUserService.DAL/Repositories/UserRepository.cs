using Microsoft.EntityFrameworkCore;
using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserServiceDbContext _context;

    public UserRepository(UserServiceDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public Task<User> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddUserAsync(UserCreateRequestBodyTemplate model)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserCreateRequestBodyTemplate model)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}