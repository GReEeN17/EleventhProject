using System.ComponentModel.DataAnnotations;

namespace EleventhProject.Server.Presentation.EntityRequests;

public record LoginUserRequest(
    [Required] string Username,
    [Required] string Password);
