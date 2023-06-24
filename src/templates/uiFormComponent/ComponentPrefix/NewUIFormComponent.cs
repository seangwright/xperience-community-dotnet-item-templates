using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base.Forms;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using MyApp.Web.Components.UIFormComponents.ComponentPrefix;

[assembly: RegisterFormComponent(
    identifier: NewFormComponent.IDENTIFIER,
    componentType: typeof(NewFormComponent),
    name: "displayName Form Component")]

namespace MyApp.Web.Components.UIFormComponents.ComponentPrefix;

[ComponentAttribute(typeof(NewFormComponentAttribute))]
public class NewFormComponent : FormComponent<NewFormComponentClientProperties, string>
{
    public const string IDENTIFIER = "MyApp.Web.Components.UIFormComponents.NewFormComponent";
    public override string ClientComponentName => "@MyApp.Web.Components.UIFormComponents/NewFormComponent";

    public NewFormComponent() { }

    protected override Task ConfigureClientProperties(NewFormComponentClientProperties clientProperties)
    {
        base.ConfigureClientProperties(clientProperties);

        // Set the default values of the component

        return Task.CompletedTask;
    }
}

public class NewFormComponentClientProperties : FormComponentClientProperties<string>
{

}

public class NewFormComponentAttribute : FormComponentAttribute
{
}
