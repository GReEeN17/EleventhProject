namespace EleventhProject.Server.Application.Middlewares;

public class JwtOptions
{
    public string SecretKey { get; set; }
    public int ExpiresHours { get; set; }
}