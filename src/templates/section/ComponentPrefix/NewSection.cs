using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Components.Sections.ComponentPrefix;

[assembly: RegisterSection(
    identifier: NewSection.IDENTIFIER,
    viewComponentType: typeof(NewSection),
    name: "displayName Section",
    propertiesType: typeof(NewSectionProperties),
    Description = "A displayName Section.",
    // https://devnet.kentico.com/docs/icon-list/index.html
    IconClass = "icon-dialog-window-cogwheel")]

namespace MyApp.Web.Components.Sections.ComponentPrefix;

public class NewSection : ViewComponent
{
    public const string IDENTIFIER = "MyApp.Web.Components.Sections.NewSection";

    public NewSection() { }

    public async Task<IViewComponentResult> InvokeAsync(ComponentViewModel<NewSectionProperties> cvm)
    {
        var vm = new NewSectionViewModel(cvm.Properties);

        await Task.CompletedTask;

        return View(vm);
    }
}

public class NewSectionProperties : ISectionProperties
{
    [TextInputComponent(
        Label = "Label",
        ExplanationText = "A custom label",
        Tooltip = "Enter a label",
        Order = 1)]
    public string Label { get; set; } = "";
}

public class NewSectionViewModel
{
    public NewSectionViewModel(NewSectionProperties props)
    {
        Label = props.Label;
    }

    public string Label { get; } = "";
}
