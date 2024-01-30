using Volo.Abp;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GePessoaFisica.MongoDB;

public static class GePessoaFisicaMongoDbContextExtensions
{
    public static void ConfigureGePessoaFisica(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
