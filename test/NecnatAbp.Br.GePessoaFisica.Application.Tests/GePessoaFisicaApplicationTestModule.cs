using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(GePessoaFisicaApplicationModule),
    typeof(GePessoaFisicaDomainTestModule)
    )]
public class GePessoaFisicaApplicationTestModule : AbpModule
{

}
