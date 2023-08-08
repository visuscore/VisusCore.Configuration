using OrchardCore.Data.Migration;
using VisusCore.Configuration.VideoStream.Core.Models;
using YesSql.Sql;

namespace VisusCore.Configuration.VideoStream.Migrations;

public class StreamEntityPartIndexMigrations : DataMigration
{
    public int Create()
    {
        SchemaBuilder.CreateMapIndexTable<StreamEntityPartIndex>(table => table
            .MapContentPartIndex()
            .Column(model => model.Name, column => column.WithLength(1024))
            .Column(model => model.Enabled));

        return 1;
    }
}
