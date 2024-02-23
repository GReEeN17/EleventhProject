using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;

namespace EleventhProject.Server.Infrastructure.Entities.PetVaccination;

public class PetVaccinationEntity : Entity
{
    public int VaccinationDictId { get; set; }
    public VaccinationDictEntity VaccinationDict { get; set; }
}