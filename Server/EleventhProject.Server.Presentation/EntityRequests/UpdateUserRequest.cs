using System.ComponentModel.DataAnnotations;

namespace EleventhProject.Server.Presentation.EntityRequests;

public record UpdateUserRequest(
    [Required] int UserId, 
    [Required] int CityId, 
    [Required] string Username, 
    [Required] string Password, 
    [Required] long PhoneNumber, 
    [Required] string Surname, 
    [Required] string Name,
    [Required] string MiddleName, 
    [Required] bool NotReadyForDonation, 
    [Required] DateTime? AbsenceBeginDate, 
    [Required] DateTime? AbsenceEndDate);