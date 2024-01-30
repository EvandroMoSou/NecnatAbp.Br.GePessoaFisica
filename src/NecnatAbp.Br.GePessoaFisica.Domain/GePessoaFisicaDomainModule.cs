using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(GePessoaFisicaDomainSharedModule)
)]
public class GePessoaFisicaDomainModule : AbpModule
{

}
