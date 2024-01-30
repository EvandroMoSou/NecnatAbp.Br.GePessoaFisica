using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GePessoaFisica;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class GePessoaFisicaApplicationTestBase<TStartupModule> : GePessoaFisicaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
