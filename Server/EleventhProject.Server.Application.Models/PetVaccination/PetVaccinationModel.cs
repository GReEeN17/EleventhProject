using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.Pet;
using EleventhProject.Server.Application.Models.VaccinationDict;

namespace EleventhProject.Server.Application.Models.PetVaccination;

public class PetVaccinationModel : Model
{
    public VaccinationDictModel VaccinationDict { get; set; }
    public PetModel Pet { get; set; }
}