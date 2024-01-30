using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GePessoaFisica.EntityFrameworkCore;

[ConnectionStringName(GePessoaFisicaDbProperties.ConnectionStringName)]
public class GePessoaFisicaDbContext : AbpDbContext<GePessoaFisicaDbContext>, IGePessoaFisicaDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public GePessoaFisicaDbContext(DbContextOptions<GePessoaFisicaDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureGePessoaFisica();
    }
}
