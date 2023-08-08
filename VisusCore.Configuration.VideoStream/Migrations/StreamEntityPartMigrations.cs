using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using VisusCore.Configuration.VideoStream.Core.Models;

namespace VisusCore.Configuration.VideoStream.Migrations;

public class StreamEntityPartMigrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public StreamEntityPartMigrations(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition<StreamEntityPart>(definition => definition
            .Configure(definition => definition
                .Attachable()
                .WithDisplayName("Stream Entity")));

        return 1;
    }
}
