namespace EleventhProject.Server.Application.Models.Abstractions;

public interface IModel
{
    int Id { get; set; }
    bool IsActive { get; set; }
}