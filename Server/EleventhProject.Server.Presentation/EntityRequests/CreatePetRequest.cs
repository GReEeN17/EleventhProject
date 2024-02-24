using System.ComponentModel.DataAnnotations;

namespace EleventhProject.Server.Presentation.EntityRequests;

public record CreatePetRequest(
    [Required] int UserId, 
    [Required] int PetTypeId, 
    [Required] int BreedId, 
    [Required] int BloodTypeId, 
    [Required] string Name, 
    [Required] int Age, 
    [Required] int Weight);