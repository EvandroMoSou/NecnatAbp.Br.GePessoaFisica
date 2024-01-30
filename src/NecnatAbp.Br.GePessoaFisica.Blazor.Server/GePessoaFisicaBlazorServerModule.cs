using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(GePessoaFisicaBlazorModule)
    )]
public class GePessoaFisicaBlazorServerModule : AbpModule
{

}
