namespace EleventhProject.Server.Infrastructure.Entities.Abstractions;

public abstract class Entity : IEntity
{
    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
}