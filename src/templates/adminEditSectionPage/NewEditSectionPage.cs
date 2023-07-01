using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: UIPage(
    parentType: typeof(NewListPage),
    slug: PageParameterConstants.PARAMETERIZED_SLUG,
    uiPageType: typeof(NewEditSectionPage),
    name: "DisplayName Edit",
    templateName: TemplateNames.SECTION_LAYOUT,
    icon: Icons.CustomElement,
    order: 0)]

namespace MySite.Admin.ModulePrefix;

// TODO replace with your own BaseInfo type
public class NewEditSectionPage : EditSectionPage<NewInfo>
{
}

