using EleventhProject.Server.Infrastructure.Entities.Abstractions;

namespace EleventhProject.Server.Infrastructure.Entities.BloodType;

public class BloodTypeEntity(string title) : Entity
{
    public string Title { get; set; } = title;
}