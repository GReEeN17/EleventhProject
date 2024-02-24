using System.ComponentModel.DataAnnotations;

namespace EleventhProject.Server.Presentation.EntityRequests;

public record CreateUserRequest(
    [Required] int CityId,
    [Required] string Username,
    [Required] string Password,
    [Required] long PhoneNumber,
    [Required] string Surname,
    [Required] string Name,
    [Required] string MiddleName);
