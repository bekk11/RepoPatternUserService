using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Response;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.Service.Interfaces;

public interface IUserService
{
    public Task<IBaseResponse<IEnumerable<User>>> ListUserService();
    
    public Task<IBaseResponse<User>> CreateUserService(UserCreateRequestBodyTemplate template);
}