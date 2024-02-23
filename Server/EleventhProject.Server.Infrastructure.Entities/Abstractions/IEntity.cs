namespace EleventhProject.Server.Infrastructure.Entities.Abstractions;

public interface IEntity
{
    int Id { get; set; }
    bool IsActive { get; set; }
}