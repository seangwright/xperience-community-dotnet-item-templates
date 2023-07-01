using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: UIPage(
    parentType: typeof(NewApplicationPage),
    slug: "list",
    uiPageType: typeof(NewListPage),
    name: "DisplayName",
    templateName: TemplateNames.SECTION_LAYOUT,
    icon: Icons.CustomElement,
    order: 0)]

namespace MySite.Admin.ModulePrefix;

public class NewListPage : ListingPage
{
    // TODO replace with your object type reference
    protected override string ObjectType => NewInfo.OBJECT_TYPE;
}
