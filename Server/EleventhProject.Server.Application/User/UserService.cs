using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Infrastructure.Entities.City;
using EleventhProject.Server.Infrastructure.Entities.User;

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
    
    public Task<string> GetUserById(int id)
    {
        var entity = _userRepository.GetUser().Where(user => user.Id == id);
        var model = _mapper.Map<UserModel>(entity.First());

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

    public Task<string> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<string> CreateUser(int cityId, string username, string password, long phoneNumber, string surname, string name,
        string middleName)
    {
        var cityModel = _cityService.GetCityById(cityId).Result;
        var userModel = new UserModel(cityModel, username, password, phoneNumber, surname, name, middleName);
        //var entity = _mapper.Map<UserEntity>(userModel);
        var entity = UserMapper.MapToEntity(userModel);
        //var entity = new UserEntity(new CityEntity(userModel.City.Title), userModel.UserName, userModel.Password, userModel.PhoneNumber, userModel.Surname, userModel.Name, userModel.MiddleName);

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

public static class UserMapper
{
    public static UserEntity MapToEntity(UserModel userModel)
    {
        if (userModel == null)
            return null;

        return new UserEntity
        {
            City = new CityEntity(userModel.City.Title),
            UserName = userModel.UserName,
            Password = userModel.Password,
            PhoneNumber = userModel.PhoneNumber,
            Surname = userModel.Surname,
            Name = userModel.Name,
            MiddleName = userModel.MiddleName,
            NotReadyForDonation = userModel.NotReadyForDonation,
            AbsenceBeginDate = userModel.AbsenceBeginDate,
            AbsenceEndDate = userModel.AbsenceEndDate
        };
    }
}