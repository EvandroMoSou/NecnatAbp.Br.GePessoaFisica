using NecnatAbp.Br.GePessoaFisica.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NecnatAbp.Br.GePessoaFisica.Permissions;

public class GePessoaFisicaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GePessoaFisicaPermissions.GroupName, L("Permission:GePessoaFisica"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GePessoaFisicaResource>(name);
    }
}
