using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class GePessoaFisicaDomainTestBase<TStartupModule> : GePessoaFisicaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
