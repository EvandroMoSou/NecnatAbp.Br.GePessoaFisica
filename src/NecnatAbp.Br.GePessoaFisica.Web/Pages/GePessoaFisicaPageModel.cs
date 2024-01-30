using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NecnatAbp.Br.GePessoaFisica.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class GePessoaFisicaPageModel : AbpPageModel
{
    protected GePessoaFisicaPageModel()
    {
        LocalizationResourceType = typeof(GePessoaFisicaResource);
        ObjectMapperContext = typeof(GePessoaFisicaWebModule);
    }
}
