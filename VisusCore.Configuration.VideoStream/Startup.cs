using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using VisusCore.AidStack.OrchardCore.Extensions;
using VisusCore.Configuration.VideoStream.Core.Models;
using VisusCore.Configuration.VideoStream.Drivers;
using VisusCore.Configuration.VideoStream.Indexing;
using VisusCore.Configuration.VideoStream.Migrations;

namespace VisusCore.Configuration.VideoStream;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataMigration<StreamEntityPartMigrations>();
        services.AddDataMigration<StreamEntityPartIndexMigrations>();
        services.AddScopedContentPartIndexProvider<
            StreamEntityPartIndexProvider,
            StreamEntityPart,
            StreamEntityPartIndex>();
        services.AddContentPart<StreamEntityPart>()
            .UseDisplayDriver<StreamEntityDisplayDriver>();
    }
}
