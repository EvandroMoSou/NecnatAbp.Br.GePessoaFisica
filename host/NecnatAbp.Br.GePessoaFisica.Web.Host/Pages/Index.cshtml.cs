using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace NecnatAbp.Br.GePessoaFisica.Pages;

public class IndexModel : GePessoaFisicaPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
