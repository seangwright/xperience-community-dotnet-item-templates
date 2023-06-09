using CMS;
using Kentico.Xperience.Admin.Base;
using MySite.Admin.ModulePrefix;

[assembly: RegisterModule(typeof(NewAdminModule))]

[assembly: UICategory(
    codeName: NewAdminModule.CATEGORY,
    name: "DisplayName",
    icon: Icons.CustomElement,
    order: 100)]

namespace MySite.Admin.ModulePrefix;

internal class NewAdminModule : AdminModule
{
    public const string CATEGORY = "MySite.Admin.ModulePrefix";

    public NewAdminModule() : base("MySite.Admin.ModulePrefix") { }

    protected override void OnInit()
    {
        base.OnInit();

        RegisterClientModule("MySite.Admin", "ModulePrefix");
    }
}