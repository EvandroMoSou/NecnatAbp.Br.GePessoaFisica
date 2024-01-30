using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NecnatAbp.Br.GePessoaFisica;

public abstract class GePessoaFisicaController : AbpControllerBase
{
    protected GePessoaFisicaController()
    {
        LocalizationResource = typeof(GePessoaFisicaResource);
    }
}
