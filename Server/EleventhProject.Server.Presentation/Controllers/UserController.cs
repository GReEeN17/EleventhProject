using System.Text.Json;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Presentation.EntityRequests;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Presentation.Controllers;

public class UserController(IUserService userService) : BaseController
{
    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        try
        {
            var user = await userService.GetUserById(userId);
            
            if (user == null)
            {
                return NotFound();
            }
            
            var response = new
            {
                city = user.City.Title,
                phoneNumber = user.PhoneNumber,
                surname = user.Surname,
                name = user.Name,
                notReadyForDonation = user.NotReadyForDonation
            };
            
            return Ok(JsonSerializer.Serialize(response));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPost("user/createUser")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        try
        {
            var user = await userService.CreateUser(request.CityId, request.Username, request.Password,
                request.PhoneNumber, request.Surname, request.Name, request.MiddleName);
            
            if (user == null)
            {
                return NotFound();
            }

            var response = new
            {
                city = user.City.Title,
                phoneNumber = user.PhoneNumber,
                surname = user.Surname,
                name = user.Name,
                notReadyForDonation = user.NotReadyForDonation
            };
            
            return Ok(JsonSerializer.Serialize(response));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    
    [HttpPost("user/updateUser")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request)
    {
        try
        {
            var user = await userService.UpdateUser(request.UserId, request.CityId, request.Username, request.Password,
                request.PhoneNumber, request.Surname, request.Name, request.MiddleName, request.NotReadyForDonation, request.AbsenceBeginDate, request.AbsenceEndDate);
            
            if (user == null)
            {
                return NotFound();
            }

            var response = new
            {
                city = user.City.Title,
                phoneNumber = user.PhoneNumber,
                surname = user.Surname,
                name = user.Name,
                notReadyForDonation = user.NotReadyForDonation
            };
            
            return Ok(JsonSerializer.Serialize(response));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("user/login")]
    public async Task<IActionResult> Login(
        LoginUserRequest loginUserRequest)
    {
        var token = await userService.Login(
            loginUserRequest.Username,
            loginUserRequest.Password);

        return Ok(token);
    }
    
    [HttpPost("user/createPet")]
    public async Task<IActionResult> CreatePet([FromBody] CreatePetRequest request)
    {
        try
        {
            var pet = await userService.CreatePet(request.UserId, request.PetTypeId, request.BreedId,
                request.BloodTypeId, request.Name, request.Age, request.Weight);
            
            if (pet == null)
            {
                return NotFound();
            }

            var response = new
            {
                owner = pet.Owner.Id,
                petType = pet.PetType.Id,
                breed = pet.Breed.Id,
                bloodType = pet.BloodType.Id,
                name = pet.Name,
                age = pet.Age,
                weight = pet.Weight
            };
            
            return Ok(JsonSerializer.Serialize(response));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}