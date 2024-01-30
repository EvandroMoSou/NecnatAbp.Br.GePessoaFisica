using Localization.Resources.AbpUi;
using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(GePessoaFisicaApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class GePessoaFisicaHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(GePessoaFisicaHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<GePessoaFisicaResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
