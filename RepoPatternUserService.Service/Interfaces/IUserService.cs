using RepoPatternUserService.DAL.Response;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.Service.Interfaces;

public interface IUserService
{
    public Task<IBaseResponse<IEnumerable<User>>> ListUserService();
}