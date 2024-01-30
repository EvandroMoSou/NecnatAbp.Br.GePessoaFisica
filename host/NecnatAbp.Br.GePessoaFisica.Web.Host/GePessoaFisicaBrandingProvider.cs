using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace NecnatAbp.Br.GePessoaFisica;

[Dependency(ReplaceServices = true)]
public class GePessoaFisicaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GePessoaFisica";
}
