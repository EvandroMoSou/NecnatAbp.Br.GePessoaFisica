using Volo.Abp.Bundling;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.Host;

public class GePessoaFisicaBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
