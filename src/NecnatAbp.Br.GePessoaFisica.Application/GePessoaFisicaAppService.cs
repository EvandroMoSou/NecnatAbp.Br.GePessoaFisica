using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.Application.Services;

namespace NecnatAbp.Br.GePessoaFisica;

public abstract class GePessoaFisicaAppService : ApplicationService
{
    protected GePessoaFisicaAppService()
    {
        LocalizationResource = typeof(GePessoaFisicaResource);
        ObjectMapperContext = typeof(GePessoaFisicaApplicationModule);
    }
}
