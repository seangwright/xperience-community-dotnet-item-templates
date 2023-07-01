using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: UIPage(
    parentType: typeof(NewApplicationPage),
    slug: "list",
    uiPageType: typeof(NewListPage),
    name: "displayName",
    templateName: TemplateNames.SECTION_LAYOUT,
    order: 0)]

namespace MySite.Admin.ModulePrefix;

public class NewListPage : ListingPage
{
    protected override string ObjectType => "MyObjectInfo.OBJECT_TYPE";
}
