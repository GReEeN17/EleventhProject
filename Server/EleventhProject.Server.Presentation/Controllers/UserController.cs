using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Presentation.EntityRequests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Presentation.Controllers;

public class UserController(IUserService userService) : BaseController
{
    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        try
        {
            var user = await userService.GetUserById(userId);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("user/createUser")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        try
        {
            var user = await userService.CreateUser(request.CityId, request.Username, request.Password, request.PhoneNumber, request.Surname, request.Name, request.MiddleName);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("user/login")]
    public async Task<IActionResult> Login(
        LoginUserRequest loginUserRequest)
    {
        var token = await userService.Login(
            loginUserRequest.Username,
            loginUserRequest.Password);

        return Ok(token);
    }
}