using EleventhProject.Server.Application.Models.Abstractions;

namespace EleventhProject.Server.Application.Models.BloodType;

public class BloodTypeModel(string title) : Model
{
    public string Title { get; set; } = title;
}