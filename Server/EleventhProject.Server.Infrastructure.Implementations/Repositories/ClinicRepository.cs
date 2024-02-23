using EleventhProject.Server.Application.Abstractions.Repositories;
using EleventhProject.Server.Application.Models.Clinic;

namespace EleventhProject.Server.Infrastructure.Implementations.Repositories;

public class ClinicRepository : IClinicRepository
{
    public Task<ClinicModel> CreateClinic(string title, string address, ClinicModel city)
    {
        throw new NotImplementedException();
    }
}