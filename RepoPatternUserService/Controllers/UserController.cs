using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.Domain.Entity;

namespace RepoPatternUserService.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository userRepository)
    {
        _repository = userRepository;
    }

    [HttpGet]
    [Route("list")]
    public async Task<IActionResult> GetAllUsersAsync()
    {
        var data = await _repository.GetAllUsersAsync();

        return Ok(data);
    }
}