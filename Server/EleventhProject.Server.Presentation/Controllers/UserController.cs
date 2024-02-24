using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Presentation.Controllers;

public class UserController
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
    }
}