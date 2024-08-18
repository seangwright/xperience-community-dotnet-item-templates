using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base.Forms;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using MySite.Admin.UIFormComponents.ComponentPrefix;

[assembly: RegisterFormComponent(
    identifier: NewFormComponent.IDENTIFIER,
    componentType: typeof(NewFormComponent),
    name: "DisplayName Form Component")]

namespace MySite.Admin.UIFormComponents.ComponentPrefix;

[ComponentAttribute(typeof(NewFormComponentAttribute))]
public class NewFormComponent : FormComponent<NewFormComponentProperties, NewFormComponentClientProperties, string>
{
    public const string IDENTIFIER = "MySite.Admin.UIFormComponents.NewFormComponent";
    public override string ClientComponentName => "@MySite.Admin/NewFormComponent";

    public NewFormComponent() { }

    protected override async Task ConfigureClientProperties(NewFormComponentClientProperties clientProperties)
    {
        await base.ConfigureClientProperties(clientProperties);

        // Set the default values of the component
        clientProperties.PlaceholderText = Properties.PlaceholderText;
    }
}

public class NewFormComponentProperties : FormComponentProperties
{
    [TextInputComponent(
        Label = "Placeholder text",
        ExplanationText = "Displayed as the placeholder/watermark in the text field this component is applied to."
    )]
    public string PlaceholderText { get; set; } = "";
}

public class NewFormComponentClientProperties : FormComponentClientProperties<string>
{
    public string PlaceholderText { get; set; } = "";
}

public class NewFormComponentAttribute : FormComponentAttribute
{
    // This property name must match the NewFormComponentProperties.PlaceholderText
    // in both name and type exactly for the value to be mapped to the component
    // properties correctly
    // See: https://docs.kentico.com/developers-and-admins/customization/extend-the-administration-interface/ui-form-components/editing-components#Editingcomponents-Createeditingcomponentattributesforcustomformcomponents
    public string PlaceholderText { get; set; } = "";
}
