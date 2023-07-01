using Kentico.Xperience.Admin.Base;
using Kentico.Xperience.Admin.Base.Forms;
using MySite.Admin.ModulePrefix;

[assembly: UIPage(
    parentType: typeof(NewEditSectionPage),
    slug: "create",
    uiPageType: typeof(NewCreatePage),
    name: "DisplayName",
    templateName: TemplateNames.EDIT,
    icon: Icons.CustomElement,
    order: 0)]

namespace MySite.Admin.ModulePrefix;

public class NewCreatePage : CreatePage<NewInfo, NewEditPage>
{
    public NewCreatePage(IFormComponentMapper formComponentMapper, IFormDataBinder formDataBinder, IPageUrlGenerator pageUrlGenerator)
        : base(formComponentMapper, formDataBinder, pageUrlGenerator)
    {
    }
}
