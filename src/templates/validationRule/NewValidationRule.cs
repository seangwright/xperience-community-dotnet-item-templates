using Kentico.Xperience.Admin.Base.Forms;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using MySite.Admin.Validation;
using System.Threading.Tasks;
using CMS.Core;
using System;

[assembly: RegisterFormValidationRule(
    identifier: NewValidationRule.IDENTIFIER,
    ruleType: typeof(NewValidationRule),
    name: "DisplayName",
    description: "A DisplayName Validation Rule.")]

namespace MySite.Admin.Validation;

[ValidationRuleAttribute(typeof(NewValidationRuleAttribute))]
public class NewValidationRule : ValidationRule<NewValidationRuleProperties, NewValidationRuleClientProperties, string>
{
    public const string IDENTIFIER = "MySite.Admin.Validation.NewValidationRule";

    private readonly ILocalizationService localizer;

    public override string ClientRuleName => "@MySite.Admin/NewValidationRule";

    public NewValidationRule(ILocalizationService localizer)
    {
        this.localizer = localizer;
    }

    public override Task<ValidationResult> Validate(string value, IFormFieldValueProvider formFieldValueProvider)
    {
        if (Random.Shared.Next() > 10)
        {
            return ValidationResult.FailResult(localizer.LocalizeString("Please enter a valid value."));
        }

        return ValidationResult.SuccessResult();
    }

    protected override Task ConfigureClientProperties(NewValidationRuleClientProperties clientProperties)
    {
        return base.ConfigureClientProperties(clientProperties);
    }
}

public class NewValidationRuleProperties : ValidationRuleProperties
{
    [TextInputComponent(
        Label = "Value",
        ExplanationText = "A value to validate against",
        Tooltip = "Enter a value",
        Order = 1)]
    public string Value { get; set; }

    public override string GetDescriptionText(ILocalizationService localizationService)
    {
        return "";
    }
}

public class NewValidationRuleClientProperties : ValidationRuleClientProperties
{
    public string Value { get; set; }
}

public class NewValidationRuleAttribute : ValidationRuleAttribute
{
    public NewValidationRuleAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; set; }
}
