using OrchardCore.ContentManagement;
using System;
using VisusCore.AidStack.OrchardCore.Parts.Indexing;
using VisusCore.Configuration.VideoStream.Core.Models;

namespace VisusCore.Configuration.VideoStream.Indexing;

public class StreamEntityPartIndexProvider : ContentPartIndexProvider<StreamEntityPart, StreamEntityPartIndex>
{
    public StreamEntityPartIndexProvider(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    protected override StreamEntityPartIndex CreateIndex(StreamEntityPart part, ContentItem contentItem)
    {
        if (part is null)
        {
            throw new ArgumentNullException(nameof(part));
        }

        if (contentItem is null)
        {
            throw new ArgumentNullException(nameof(contentItem));
        }

        return new()
        {
            ContentItemId = contentItem.ContentItemId,
            ContentItemVersionId = contentItem.ContentItemVersionId,
            ContentType = contentItem.ContentType,
            Latest = contentItem.Latest,
            Published = contentItem.Published,
            Enabled = part.Enabled,
            Name = part.Name,
        };
    }
}
