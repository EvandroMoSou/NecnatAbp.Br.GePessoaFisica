using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(GePessoaFisicaDomainModule),
    typeof(GePessoaFisicaApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class GePessoaFisicaApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<GePessoaFisicaApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<GePessoaFisicaApplicationModule>(validate: true);
        });
    }
}
