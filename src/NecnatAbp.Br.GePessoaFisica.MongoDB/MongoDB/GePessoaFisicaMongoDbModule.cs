using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB;

[DependsOn(
    typeof(GePessoaFisicaDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class GePessoaFisicaMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<GePessoaFisicaMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
