using EleventhProject.Server.Application.Models.Abstractions;
using EleventhProject.Server.Application.Models.BloodType;
using EleventhProject.Server.Application.Models.Breed;
using EleventhProject.Server.Application.Models.PetType;
using EleventhProject.Server.Application.Models.User;

namespace EleventhProject.Server.Application.Models.Pet;

public class PetModel : Model
{
    public UserModel Owner { get; set; }
    public PetTypeModel PetType { get; set; }
    public BreedModel Breed { get; set; }
    public BloodTypeModel BloodType { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
}