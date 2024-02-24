using System.IdentityModel.Tokens.Jwt;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EleventhProject.Server.Presentation.Controllers;

public class UserController : BaseController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        UserModel user = await _userService.GetUserById(id);

        if (user is null)
        {
            return BadRequest(new { errorText = "Invalid username or password" });
        }

        var now = DateTime.UtcNow;
        return Ok(user);
    }
}