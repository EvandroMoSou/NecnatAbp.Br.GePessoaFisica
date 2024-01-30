using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(GePessoaFisicaDomainModule),
    typeof(GePessoaFisicaTestBaseModule)
)]
public class GePessoaFisicaDomainTestModule : AbpModule
{

}
