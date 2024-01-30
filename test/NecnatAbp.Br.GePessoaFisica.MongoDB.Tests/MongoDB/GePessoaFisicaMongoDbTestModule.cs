using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB;

[DependsOn(
    typeof(GePessoaFisicaApplicationTestModule),
    typeof(GePessoaFisicaMongoDbModule)
)]
public class GePessoaFisicaMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
