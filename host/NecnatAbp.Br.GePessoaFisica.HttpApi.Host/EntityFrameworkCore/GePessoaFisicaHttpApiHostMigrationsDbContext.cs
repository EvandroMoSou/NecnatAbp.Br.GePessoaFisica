using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GePessoaFisica.EntityFrameworkCore;

public class GePessoaFisicaHttpApiHostMigrationsDbContext : AbpDbContext<GePessoaFisicaHttpApiHostMigrationsDbContext>
{
    public GePessoaFisicaHttpApiHostMigrationsDbContext(DbContextOptions<GePessoaFisicaHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureGePessoaFisica();
    }
}
