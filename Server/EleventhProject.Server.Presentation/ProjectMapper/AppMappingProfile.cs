using AutoMapper;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.City;
using EleventhProject.Server.Application.Models.Clinic;
using EleventhProject.Server.Application.Models.DonationHistory;
using EleventhProject.Server.Application.Models.DonorSearchCard;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.PetVaccination;
using EleventhProject.Server.Application.Models.User;
using EleventhProject.Server.Application.Models.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.BloodType;
using EleventhProject.Server.Infrastructure.Entities.Breed;
using EleventhProject.Server.Infrastructure.Entities.City;
using EleventhProject.Server.Infrastructure.Entities.Clinic;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;
using EleventhProject.Server.Infrastructure.Entities.Pet;
using EleventhProject.Server.Infrastructure.Entities.PetType;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;
using EleventhProject.Server.Infrastructure.Entities.User;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Presentation.ProjectMapper;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<UserEntity, UserModel>().ReverseMap();
        CreateMap<BloodTypeEntity, BloodTypeModel>().ReverseMap();
        CreateMap<BreedEntity, BreedModel>().ReverseMap();
        CreateMap<CityEntity, CityModel>().ReverseMap();
        CreateMap<ClinicEntity, ClinicModel>().ReverseMap();
        CreateMap<DonationHistoryEntity, DonationHistoryModel>().ReverseMap();
        CreateMap<DonorSearchCardEntity, DonorSearchCardModel>().ReverseMap();
        CreateMap<PetEntity, PetModel>().ReverseMap();
        CreateMap<PetTypeEntity, PetTypeModel>().ReverseMap();
        CreateMap<PetVaccinationEntity, PetVaccinationModel>().ReverseMap();
        CreateMap<VaccinationDictEntity, VaccinationDictModel>().ReverseMap();
    }
}