using EleventhProject.Server.Application.Contracts.PetType;
using EleventhProject.Server.Presentation.EntityRequests;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Presentation.Controllers;

public class PetTypeController(IPetTypeService petTypeService) : BaseController
{
    [HttpPost("petType/createPetType")]
    public async Task<IActionResult> CreatePetType([FromBody] CreatePetTypeRequest request)
    {
        try
        {
            var petType = await petTypeService.CreatePetType(request.title);
            
            if (petType == null)
            {
                return NotFound();
            }

            return Ok(petType);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}