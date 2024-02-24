using System.ComponentModel.DataAnnotations;

namespace EleventhProject.Server.Presentation.EntityRequests;

public record CreatePetTypeRequest(
    [Required] string title);