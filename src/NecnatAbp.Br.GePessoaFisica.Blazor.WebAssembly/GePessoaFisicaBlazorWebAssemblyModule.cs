using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.WebAssembly;

[DependsOn(
    typeof(GePessoaFisicaBlazorModule),
    typeof(GePessoaFisicaHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class GePessoaFisicaBlazorWebAssemblyModule : AbpModule
{

}
