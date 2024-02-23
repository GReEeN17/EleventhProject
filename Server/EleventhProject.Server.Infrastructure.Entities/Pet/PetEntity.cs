using EleventhProject.Server.Infrastructure.Entities.Abstractions;
using EleventhProject.Server.Infrastructure.Entities.BloodType;
using EleventhProject.Server.Infrastructure.Entities.Breed;
using EleventhProject.Server.Infrastructure.Entities.PetType;
using EleventhProject.Server.Infrastructure.Entities.User;

namespace EleventhProject.Server.Infrastructure.Entities.Pet;

public class PetEntity : Entity
{
    public UserEntity Owner { get; set; }
    public PetTypeEntity PetType { get; set; }
    public BreedEntity Breed { get; set; }
    public BloodTypeEntity BloodType { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
}