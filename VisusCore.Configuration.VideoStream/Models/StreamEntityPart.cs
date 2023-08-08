using OrchardCore.ContentManagement;

namespace VisusCore.Configuration.VideoStream.Core.Models;

public class StreamEntityPart : ContentPart
{
    public string Name { get; set; }
    public bool Enabled { get; set; }
}
