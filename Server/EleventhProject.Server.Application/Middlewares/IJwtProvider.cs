using EleventhProject.Server.Application.Models.User;
using Microsoft.Extensions.Options;

namespace EleventhProject.Server.Application.Middlewares;

public interface IJwtProvider
{
    string GenerateToken(UserModel user);
}