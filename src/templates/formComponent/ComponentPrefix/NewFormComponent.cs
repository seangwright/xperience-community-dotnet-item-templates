using MyApp.Web.Components.Widgets.ComponentPrefix;
using Kentico.Forms.Web.Mvc;
using CMS.DataEngine;

[assembly: RegisterFormComponent(
    identifier: NewFormComponent.IDENTIFIER,
    formComponentType: typeof(NewFormComponent),
    name: "displayName Form Component",
    Description = "A displayName Form Component.",
    // https://devnet.kentico.com/docs/icon-list/index.html
    IconClass = "icon-dialog-window-cogwheel",
    IsAvailableInFormBuilderEditor = false,
    IsMappableToContactFields = false,
    ViewName = "~/Components/FormComponents/ComponentPrefix/NewFormComponent.cshtml")]

namespace MyApp.Web.Components.Widgets.ComponentPrefix;

public class NewFormComponent : FormComponent<NewFormComponentProperties, string>
{
    public const string IDENTIFIER = "MyApp.Web.Components.FormComponents.NewFormComponent";

    [BindableProperty]
    public string Value { get; set; }

    public override string GetValue()
    {
        return Value;
    }

    public override void SetValue(string value)
    {
        Value = value;
    }
}

public class NewFormComponentProperties : FormComponentProperties<string>
{
    public NewFormComponentProperties() : base(FieldDataType.Text, size: 200) { }

    [DefaultValueEditingComponent(TextInputComponent.IDENTIFIER)]
    public override string DefaultValue { get; set; } = "";
}

