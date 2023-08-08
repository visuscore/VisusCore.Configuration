using System.ComponentModel.DataAnnotations;

namespace VisusCore.Configuration.VideoStream.ViewModels;

public class StreamEntityEditViewModel
{
    [Required]
    public string Name { get; set; }
    public bool Enabled { get; set; } = true;
}
