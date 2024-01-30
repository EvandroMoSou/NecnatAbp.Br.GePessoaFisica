using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB;

[ConnectionStringName(GePessoaFisicaDbProperties.ConnectionStringName)]
public class GePessoaFisicaMongoDbContext : AbpMongoDbContext, IGePessoaFisicaMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureGePessoaFisica();
    }
}
