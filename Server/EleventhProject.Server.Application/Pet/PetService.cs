using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.Pet;

public class PetService : IPetService
{
    public Task<IActionResult> CreatePet(UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        /*var cityModel = _cityService.GetCityById(cityId).Result;
        var userModel = new UserModel(cityModel, username, password, phoneNumber, surname, name, middleName);
        var entity = _mapper.Map<UserEntity>(userModel);

        var result = _userRepository.CreateUser(entity);
        
        return Task.FromResult(JsonSerializer.Serialize(result));*/
        throw new NotImplementedException();
    }

    public Task<IActionResult> GetPetById(int petId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> UpdatePet(int petId, UserModel owner, int petTypeId, int breedId, int bloodTypeId, string name, int age,
        int weight)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IActionResult> GetAllPetsByUserId(int userId)
    {
        throw new NotImplementedException();
    }
}