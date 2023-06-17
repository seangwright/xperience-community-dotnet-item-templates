using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Components.Widgets;

[assembly: RegisterWidget(
    identifier: HeroWidget.IDENTIFIER,
    viewComponentType: typeof(HeroWidget),
    name: "displayName Widget",
    propertiesType: typeof(HeroWidgetProperties),
    Description = "A displayName Widget.",
    IconClass = Icons.CustomElement)]

namespace MyApp.Web.Components.Widgets;

public class HeroWidget : ViewComponent
{
    public const string IDENTIFIER = "MyApp.Web.Components.Widgets.HeroWidget";

    public HeroWidget() { }

    public async Task<IViewComponentResult> InvokeAsync(ComponentViewModel<HeroWidgetProperties> cvm)
    {
        var vm = new HeroWidgetViewModel(cvm.Properties);

        await Task.CompletedTask;

        return View(vm);
    }

}

public class HeroWidgetProperties : IWidgetProperties
{
    [TextInputComponent(
        Label = "Label",
        ExplanationText = "A custom label",
        Tooltip = "Enter a label",
        Order = 1)]
    public string Label { get; set; } = "";
}

public class HeroWidgetViewModel
{
    public HeroWidgetViewModel(HeroWidgetProperties props)
    {
        Label = props.Label;
    }

    public string Label { get; } = "";
}
