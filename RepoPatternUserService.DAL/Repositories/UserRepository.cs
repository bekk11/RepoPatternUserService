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
    
    public async Task<IEnumerable<User>> GetAllUsersAsyncRepo()
    {
        return await _context.Users.ToListAsync();
    }

    public Task<User> GetUserByIdAsyncRepo(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddUserAsyncRepo(UserCreateRequestBodyTemplate model)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsyncRepo(UserCreateRequestBodyTemplate model)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsyncRepo(int id)
    {
        throw new NotImplementedException();
    }
}