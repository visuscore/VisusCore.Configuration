using Microsoft.AspNetCore.DataProtection;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;
using VisusCore.Configuration.VideoStream.Core.Models;
using VisusCore.Configuration.VideoStream.ViewModels;

namespace VisusCore.Configuration.VideoStream.Drivers;

public class StreamEntityDisplayDriver : ContentPartDisplayDriver<StreamEntityPart>
{
    private readonly IDataProtectionProvider _dataProtectionProvider;

    public StreamEntityDisplayDriver(IDataProtectionProvider dataProtectionProvider) =>
        _dataProtectionProvider = dataProtectionProvider;

    public override IDisplayResult Edit(StreamEntityPart part, BuildPartEditorContext context) =>
        Initialize<StreamEntityEditViewModel>(GetEditorShapeType(context), viewModel =>
        {
            viewModel.Name = part.Name;
            viewModel.Enabled = part.Enabled;
        });

    public override async Task<IDisplayResult> UpdateAsync(
        StreamEntityPart part,
        IUpdateModel updater,
        UpdatePartEditorContext context)
    {
        var viewModel = new StreamEntityEditViewModel();

        await context.Updater.TryUpdateModelAsync(viewModel, Prefix);

        part.Name = viewModel.Name;
        part.Enabled = viewModel.Enabled;

        return await EditAsync(part, context);
    }
}
