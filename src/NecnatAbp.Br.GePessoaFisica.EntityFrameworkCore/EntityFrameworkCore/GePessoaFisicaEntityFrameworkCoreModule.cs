using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica.EntityFrameworkCore;

[DependsOn(
    typeof(GePessoaFisicaDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class GePessoaFisicaEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<GePessoaFisicaDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
