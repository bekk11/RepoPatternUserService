using Microsoft.AspNetCore.Mvc;
using RepoPatternUserService.Domain.DataTemplates;
using RepoPatternUserService.Service.Interfaces;

namespace RepoPatternUserService.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    [Route("list")]
    public async Task<IActionResult> GetAllUsersAsync()
    {
        var res = await _userService.ListUserService();
        return Ok(res);
    }
    
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateUserAsync(UserCreateRequestBodyTemplate template)
    {
        var res = await _userService.CreateUserService(template);
        return Ok(res);
    }
    
    [HttpGet]
    [Route("get/{pk}")]
    public async Task<IActionResult> GetUserByIdAsync(long pk)
    {
        return Ok();
    }
    
    [HttpPut]
    [Route("update/{pk}")]
    public async Task<IActionResult> UpdateUserByIdAsync(long pk, UserCreateRequestBodyTemplate user)
    {
        return Ok();
    }
    
    [HttpDelete]
    [Route("delete/{pk}")]
    public async Task<IActionResult> DeleteUserByIdAsync(long pk)
    {
        return Ok();
    }
}