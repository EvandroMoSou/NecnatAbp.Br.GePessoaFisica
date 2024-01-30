using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(GePessoaFisicaDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class GePessoaFisicaApplicationContractsModule : AbpModule
{

}
