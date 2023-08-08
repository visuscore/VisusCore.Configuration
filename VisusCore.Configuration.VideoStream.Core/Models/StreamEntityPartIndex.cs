using VisusCore.AidStack.OrchardCore.Parts.Indexing.Models;

namespace VisusCore.Configuration.VideoStream.Core.Models;

public class StreamEntityPartIndex : ContentPartIndex
{
    public string Name { get; set; }
    public bool Enabled { get; set; }
}
