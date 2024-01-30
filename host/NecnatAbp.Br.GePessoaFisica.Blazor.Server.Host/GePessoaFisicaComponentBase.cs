using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.AspNetCore.Components;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.Server.Host;

public abstract class GePessoaFisicaComponentBase : AbpComponentBase
{
    protected GePessoaFisicaComponentBase()
    {
        LocalizationResource = typeof(GePessoaFisicaResource);
    }
}
