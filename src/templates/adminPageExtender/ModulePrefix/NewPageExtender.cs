using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base;
using Kentico.Xperience.Admin.Base.UIPages;
using MySite.Admin.ModulePrefix;

[assembly: PageExtender(typeof(NewPageExtender))]

namespace MySite.Admin.ModulePrefix;

public class NewPageExtender : PageExtender<UserList>
{
    public override Task ConfigurePage()
    {
        // modify Page.PageConfiguration;

        return base.ConfigurePage();
    }
}
