using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: UIApplication(
    identifier: NewApplicationPage.IDENTIFIER,
    type: typeof(NewApplicationPage),
    slug: "slug",
    name: "DisplayName",
    category: NewAdminModule.CATEGORY,
    icon: Icons.CustomElement,
    templateName: TemplateNames.SECTION_LAYOUT)]

namespace MySite.Admin.ModulePrefix;

public class NewApplicationPage : ApplicationPage
{
    public const string IDENTIFIER = "MySite.Admin.NewApplicationPage";
}
