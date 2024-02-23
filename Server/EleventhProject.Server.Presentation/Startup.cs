using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.BloodType;
using EleventhProject.Server.Application.Breed;
using EleventhProject.Server.Application.City;
using EleventhProject.Server.Application.Clinic;
using EleventhProject.Server.Application.Contracts.BloodType;
using EleventhProject.Server.Application.Contracts.Breed;
using EleventhProject.Server.Application.Contracts.City;
using EleventhProject.Server.Application.Contracts.Clinic;
using EleventhProject.Server.Application.Contracts.DonationHistory;
using EleventhProject.Server.Application.Contracts.DonorSearchCard;
using EleventhProject.Server.Application.Contracts.Pet;
using EleventhProject.Server.Application.Contracts.PetType;
using EleventhProject.Server.Application.Contracts.PetVaccination;
using EleventhProject.Server.Application.Contracts.User;
using EleventhProject.Server.Application.Contracts.VaccinationDict;
using EleventhProject.Server.Application.DonationHistory;
using EleventhProject.Server.Application.DonorSearchCard;
using EleventhProject.Server.Application.Pet;
using EleventhProject.Server.Application.PetType;
using EleventhProject.Server.Application.PetVaccination;
using EleventhProject.Server.Application.User;
using EleventhProject.Server.Application.VaccinationDict;
using EleventhProject.Server.Infrastructure.Entities.User;
using EleventhProject.Server.Infrastructure.Implementations.DataContext;
using EleventhProject.Server.Infrastructure.Implementations.Repositories;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace EleventhProject.Server.Presentation;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(
        IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.Conventions.Add(new RouteTokenTransformerConvention(
                new SlugifyParameterTransformer()));
            options.Filters.Add(new ErrorFilter());
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "EleventhProject API", Version = "v1" });
        });

        services.AddDbContext<DataContext>(options =>
        {
            options
                .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"),
                    assembly =>
                        assembly.MigrationsAssembly("EleventhProject.Server.Infrastructure.Migrations"));
        });

        services.AddAutoMapper(typeof(Startup));

        services.AddTransient<IBloodTypeService, BloodTypeService>();
        services.AddTransient<IBreedService, BreedService>();
        services.AddTransient<ICityService, CityService>();
        services.AddTransient<IClinicService, ClinicService>();
        services.AddTransient<IDonationHistoryService, DonationHistoryService>();
        services.AddTransient<IDonorSearchCardService, DonorSearchCardService>();
        services.AddTransient<IPetService, PetService>();
        services.AddTransient<IPetTypeService, PetTypeService>();
        services.AddTransient<IPetVaccinationService, PetVaccinationService>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IVaccinationDictService, VaccinationDictService>();
        services.AddScoped<IBloodTypeRepository, BloodTypeRepository>();
        services.AddScoped<IBreedRepository, BreedRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IClinicRepository, ClinicRepository>();
        services.AddScoped<IDonationHistoryRepository, DonationHistoryRepository>();
        services.AddScoped<IDonorSearchRepository, DonorSearchCardRepository>();
        services.AddScoped<IPetRepository, PetRepository>();
        services.AddScoped<IPetTypeRepository, PetTypeRepository>();
        services.AddScoped<IPetVaccinationRepository, PetVaccinationRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IVaccinationDictRepository, VaccinationDictRepository>();
        services.AddSingleton(new UserEntity() { Id = 0 });
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
    {
        app.UseRouting();
        app.UseAuthorization();

        app.UseSwagger();
        app.UseSwaggerUI(x =>
        {
            x.SwaggerEndpoint("/swagger/v1/swagger.json", "EleventhProject API v1");
            x.RoutePrefix = "swagger";
        });
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }

    public class SlugifyParameterTransformer : IOutboundParameterTransformer
    {
        public string TransformOutbound(object value) =>
            value is null ? null : Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower();
    }

    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override async Task OnExceptionAsync(ExceptionContext context)
        {
            var exception = context.Exception;
            var response = $"{{\"error\": \"{exception.Message}{exception.InnerException?.Message}\"}}";
            await using var responseWriter = new StreamWriter(context.HttpContext.Response.Body, Encoding.UTF8);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.HttpContext.Response.ContentType = "application/json; charset=utf-8";
            context.HttpContext.Response.ContentLength = Encoding.UTF8.GetBytes(response).Length + 3;
            await responseWriter.WriteAsync(response);
        }
    }
}