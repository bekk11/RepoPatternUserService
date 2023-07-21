using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.DAL.Utils;
using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Entity;
using RepoPatternUserService.Domain.Enum;

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
    
    public async Task<User> AddUserAsyncRepo(UserCreateRequestBodyTemplate template)
    {
        byte[] salt = PasswordHasher.GenerateSalt();
        byte[] pas_hash = PasswordHasher.HashPassword(template.Password, salt);

        var user = new User();
        
        user.CreateUser(
            firstName: template.FirstName,
            lastName: template.LastName,
            gender: template.Gender == "Male" ? Gender.Male : Gender.Female,
            passportSerNum: template.PassportSerNum,
            pinfl: template.PINFL,
            email: template.Email,
            username: template.Username,
            passwordHash: pas_hash,
            salt: salt
        );

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return user;
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