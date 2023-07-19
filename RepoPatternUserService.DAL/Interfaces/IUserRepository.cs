using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.DAL.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    
    Task<User> GetUserByIdAsync(int id);
    
    Task AddUserAsync(UserCreateRequestBodyTemplate model);
    
    Task UpdateAsync(UserCreateRequestBodyTemplate model);
    
    Task DeleteAsync(int id);
}