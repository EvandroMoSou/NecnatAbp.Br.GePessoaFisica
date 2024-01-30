using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.Menus;

public class GePessoaFisicaMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(GePessoaFisicaMenus.Prefix, displayName: "GePessoaFisica", "/GePessoaFisica", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
