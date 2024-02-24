using System.Text.Json;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.BloodType;
using EleventhProject.Server.Infrastructure.Entities.User;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.User;

public class UserService : IUserService
{
    private readonly IPetService _petService;
    private readonly IDonorSearchCardService _donorSearchCardService;
    private readonly IUserRepository _userRepository;
    private readonly ICityService _cityService;
    private readonly IMapper _mapper;

    public UserService(IPetService petService, IDonorSearchCardService donorSearchCardService, IUserRepository userRepository,
    IMapper mapper, ICityService cityService)
    {
        _petService = petService;
        _donorSearchCardService = donorSearchCardService;
        _userRepository = userRepository;
        _mapper = mapper;
        _cityService = cityService;
    }

    public Task<string> GetProfileByUserId(int id)
    {
        throw new NotImplementedException();
    }
    
    public Task<string> GetUserById(int id)
    {
        var entity = _userRepository.GetUser(id);
        var model = _mapper.Map<UserModel>(entity);

        var response = new
        {
            city = model.City.Title,
            phoneNumber = model.PhoneNumber,
            surname = model.Surname,
            name = model.Name,
            notReadyForDonation = model.NotReadyForDonation
        };

        return Task.FromResult(JsonSerializer.Serialize(response));
    }

    public Task<string> CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName)
    {
        var cityModel = _cityService.GetCityById(cityId).Result;
        var userModel = new UserModel(cityModel, username, password, phoneNumber, surname, name, middleName);
        var entity = _mapper.Map<UserEntity>(userModel);

        var result = _userRepository.CreateUser(entity);
        
        return Task.FromResult(JsonSerializer.Serialize(result));
    }

    public Task<string> UpdateUser(int userId, int cityId, string username, string password, long phoneNumber, string surname,
        string name, string middleName, bool notReadyForDonation, DateTime? AbsenseBeginDate, DateTime? AbsenceEndDate)
    {
        throw new NotImplementedException();
    }

    public Task CreatePet(int userId, int petTypeId, int breedId, int bloodTypeId, string name, int age, int weight)
    {
        throw new NotImplementedException();
    }

    public Task CreateDonorSearchCard(int userId, int clinicId, string reason, int BloodAmount, DateTime EndDate, bool IsUrgent)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<string> GetDonationHistory(int userId)
    {
        throw new NotImplementedException();
    }
}