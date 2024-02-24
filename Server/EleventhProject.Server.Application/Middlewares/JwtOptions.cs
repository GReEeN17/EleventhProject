namespace EleventhProject.Server.Application.Middlewares;

public class JwtOptions
{
    public string SecretKey { get; set; } = "Eleventh_will_win_this_hakathon_do_not_doubt_about_this";
    public int ExpiresHours { get; set; } = 12;
}