using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace NecnatAbp.Br.GePessoaFisica;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class GePessoaFisicaInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<GePessoaFisicaInstallerModule>();
        });
    }
}
