using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NecnatAbp.Br.GePessoaFisica.Pages;

public abstract class GePessoaFisicaPageModel : AbpPageModel
{
    protected GePessoaFisicaPageModel()
    {
        LocalizationResourceType = typeof(GePessoaFisicaResource);
    }
}
