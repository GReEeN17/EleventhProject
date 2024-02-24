using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EleventhProject.Server.Application.Models.User;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace EleventhProject.Server.Application.Middlewares;

public class JwtProvider : IJwtProvider
{
    private readonly JwtOptions _options;
    
    public JwtProvider(IOptions<JwtOptions> options)
    {
        _options = options.Value;
    }
    
    public string GenerateToken(UserModel user)
    {
        Claim[] claims = [new ("id", user.Id.ToString()),
                          new Claim("username", user.UserName)];
        
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            signingCredentials: signingCredentials,
            expires: DateTime.UtcNow.AddHours(_options.ExpiresHours));

        var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }

    public string GenerateToken(IOptions<JwtOptions> options)
    {
        throw new NotImplementedException();
    }
}