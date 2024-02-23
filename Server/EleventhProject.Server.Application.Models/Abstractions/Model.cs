namespace EleventhProject.Server.Application.Models.Abstractions;

public class Model : IModel
{
    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
}