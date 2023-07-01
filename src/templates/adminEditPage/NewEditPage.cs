using Kentico.Xperience.Admin.Base;
using Kentico.Xperience.Admin.Base.Forms;
using MySite.Admin.ModulePrefix;

[assembly: UIPage(
    parentType: typeof(NewEditSectionPage),
    slug: "edit",
    uiPageType: typeof(NewEditPage),
    name: "DisplayName",
    templateName: TemplateNames.EDIT,
    icon: Icons.CustomElement,
    order: 0)]

namespace MySite.Admin.ModulePrefix;

public class NewEditPage : InfoEditPage<NewInfo>
{
    public NewEditPage(IFormComponentMapper formComponentMapper, IFormDataBinder formDataBinder)
        : base(formComponentMapper, formDataBinder)
    {
    }

    [PageParameter(typeof(IntPageModelBinder))]
    public override int ObjectId { get; set; }
}
