using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.DAL.Repositories;
using RepoPatternUserService.DAL.Response;
using RepoPatternUserService.Domain.Entity;
using RepoPatternUserService.Service.Interfaces;

namespace RepoPatternUserService.Service.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(UserRepository userRepository)
    {   
        _userRepository = userRepository;
        // _logger = logger;
    }

    public async Task<IBaseResponse<IEnumerable<User>>> ListUserService()
    {
        return new BaseResponse<IEnumerable<User>>(
            success: true,
            message: "SUCCESS",
            data: await _userRepository.GetAllUsersAsyncRepo()
        );
    }
}