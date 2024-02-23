using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.Pet;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Infrastructure.Entities.PetVaccination;

public class PetVaccinationEntity : Entity
{
    public VaccinationDictEntity VaccinationDict { get; set; }
    public PetEntity Pet { get; set; }
}