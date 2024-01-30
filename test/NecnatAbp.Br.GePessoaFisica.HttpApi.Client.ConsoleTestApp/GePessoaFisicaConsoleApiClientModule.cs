using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GePessoaFisicaHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class GePessoaFisicaConsoleApiClientModule : AbpModule
{

}
