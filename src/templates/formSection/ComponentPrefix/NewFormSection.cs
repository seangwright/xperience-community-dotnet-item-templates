using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using Microsoft.AspNetCore.Mvc;
using MySite.Web.Components.FormSections.ComponentPrefix;
using Kentico.Forms.Web.Mvc;

[assembly: RegisterFormSection(
    identifier: NewFormSection.IDENTIFIER,
    viewComponentType: typeof(NewFormSection),
    name: "DisplayName",
    PropertiesType = typeof(NewFormSectionProperties),
    Description = "A DisplayName Form Section.",
    // https://devnet.kentico.com/docs/icon-list/index.html
    IconClass = "icon-dialog-window-cogwheel")]

namespace MySite.Web.Components.FormSections.ComponentPrefix;

public class NewFormSection : ViewComponent
{
    public const string IDENTIFIER = "MySite.Web.Components.FormSections.NewFormSection";

    public NewFormSection() { }

    public async Task<IViewComponentResult> InvokeAsync(FormSectionViewModel<NewFormSectionProperties> cvm)
    {
        var vm = new NewFormSectionViewModel(cvm.Properties);

        await Task.CompletedTask;

        return View("~/Components/FormSections/NewFormSection/NewFormSection.cshtml", vm);
    }
}

public class NewFormSectionProperties : IFormSectionProperties
{
    [TextInputComponent(
        Label = "Label",
        ExplanationText = "A custom label",
        Tooltip = "Enter a label",
        Order = 1)]
    public string Label { get; set; } = "";
}

public class NewFormSectionViewModel
{
    public NewFormSectionViewModel(NewFormSectionProperties props)
    {
        Label = props.Label;
    }

    public string Label { get; } = "";
}
