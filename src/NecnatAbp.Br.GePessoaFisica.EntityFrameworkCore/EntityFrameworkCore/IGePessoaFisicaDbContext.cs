using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GePessoaFisica.EntityFrameworkCore;

[ConnectionStringName(GePessoaFisicaDbProperties.ConnectionStringName)]
public interface IGePessoaFisicaDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
