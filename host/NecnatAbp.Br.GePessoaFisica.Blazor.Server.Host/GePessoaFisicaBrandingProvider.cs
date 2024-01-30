using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NecnatAbp.Br.GePessoaFisica.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class GePessoaFisicaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GePessoaFisica";
}
