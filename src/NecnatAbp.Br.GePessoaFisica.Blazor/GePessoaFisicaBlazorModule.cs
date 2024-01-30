using Microsoft.Extensions.DependencyInjection;
using NecnatAbp.Br.GePessoaFisica.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace NecnatAbp.Br.GePessoaFisica.Blazor;

[DependsOn(
    typeof(GePessoaFisicaApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class GePessoaFisicaBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<GePessoaFisicaBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<GePessoaFisicaBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new GePessoaFisicaMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(GePessoaFisicaBlazorModule).Assembly);
        });
    }
}
