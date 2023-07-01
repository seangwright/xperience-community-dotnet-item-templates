using System.Threading.Tasks;
using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: PageExtender(typeof(NewPageExtender))]

namespace MySite.Admin.ModulePrefix;

public class NewPageExtender : PageExtender<NewListPage>
{
    public override Task ConfigurePage()
    {
        // modify Page.PageConfiguration;

        return base.ConfigurePage();
    }
}
