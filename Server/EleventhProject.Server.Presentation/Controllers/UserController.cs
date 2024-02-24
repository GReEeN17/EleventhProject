using EleventhProject.Server.Application.Contracts.User;
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
    public async Task<IActionResult> CreateUser(int cityId, string username, string password, 
        long phoneNumber, string surname, string name, string middleName)
    {
        try
        {
            var user = await userService.CreateUser(cityId, username, password, phoneNumber, surname, name, middleName);
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
}