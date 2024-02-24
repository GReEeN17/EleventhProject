using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Infrastructure.Entities.City;
using Microsoft.AspNetCore.Mvc;

namespace EleventhProject.Server.Application.City;

public class CityService : ICityService
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public CityService(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }

    public Task<string> CreateCity(string title)
    {
        var entity = _mapper.Map<CityEntity>(new CityModel(title));
        var result = _cityRepository.CreateCity(entity);

        return Task.FromResult(JsonSerializer.Serialize(result));
    }

    public Task<CityModel> GetCityById(int cityId)
    {
        var entity = _cityRepository.GetCity().Where(city => city.Id == cityId);
        var cityModel = new CityModel(entity.First().Title);
        
        return Task.FromResult(cityModel);
    }

    public string GetAllCities()
    {
        throw new NotImplementedException();
    }
}