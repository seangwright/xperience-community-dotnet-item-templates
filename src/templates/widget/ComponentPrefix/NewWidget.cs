using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Components.Widgets.ComponentPrefix;

[assembly: RegisterWidget(
    identifier: NewWidget.IDENTIFIER,
    viewComponentType: typeof(NewWidget),
    name: "displayName Widget",
    propertiesType: typeof(NewWidgetProperties),
    Description = "A displayName Widget.",
    // https://devnet.kentico.com/docs/icon-list/index.html
    IconClass = "icon-dialog-window-cogwheel")]

namespace MyApp.Web.Components.Widgets.ComponentPrefix;

public class NewWidget : ViewComponent
{
    public const string IDENTIFIER = "MyApp.Web.Components.Widgets.NewWidget";

    public NewWidget() { }

    public async Task<IViewComponentResult> InvokeAsync(ComponentViewModel<NewWidgetProperties> cvm)
    {
        var vm = new NewWidgetViewModel(cvm.Properties);

        await Task.CompletedTask;

        return View(vm);
    }
}

public class NewWidgetProperties : IWidgetProperties
{
    [TextInputComponent(
        Label = "Label",
        ExplanationText = "A custom label",
        Tooltip = "Enter a label",
        Order = 1)]
    public string Label { get; set; } = "";
}

public class NewWidgetViewModel
{
    public NewWidgetViewModel(NewWidgetProperties props)
    {
        Label = props.Label;
    }

    public string Label { get; } = "";
}
