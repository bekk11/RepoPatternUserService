using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Domain.Response;
using RepoPatternUserService.Domain.Entity;
using RepoPatternUserService.Service.Interfaces;

namespace RepoPatternUserService.Service.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IBaseResponse<IEnumerable<User>>> ListUserService()
    {
        try
        {
            return new BaseResponse<IEnumerable<User>>(
                success: true,
                message: "SUCCESS",
                data: await _userRepository.GetAllUsersAsyncRepo()
            );
        }
        catch (Exception e)
        {
            return new BaseResponse<IEnumerable<User>>(
                success: false,
                message: e.Message,
                data: null
            );
        }
    }

    public async Task<IBaseResponse<User>> CreateUserService(UserCreateRequestBodyTemplate template)
    {
        try
        {
            return new BaseResponse<User>(
                success: true,
                message: "User created Successfully!!!",
                data: await _userRepository.AddUserAsyncRepo(template)
            );
        }
        catch (Exception e)
        {
            return new BaseResponse<User>(
                success: false,
                message: e.Message,
                data: null
            );
        }
    }
}