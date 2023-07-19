using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.DAL.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsyncRepo();
    
    Task<User> GetUserByIdAsyncRepo(int id);
    
    Task AddUserAsyncRepo(UserCreateRequestBodyTemplate model);
    
    Task UpdateAsyncRepo(UserCreateRequestBodyTemplate model);
    
    Task DeleteAsyncRepo(int id);
}