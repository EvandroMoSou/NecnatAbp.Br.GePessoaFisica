using Volo.Abp.Reflection;

namespace NecnatAbp.Br.GePessoaFisica.Permissions;

public class GePessoaFisicaPermissions
{
    public const string GroupName = "GePessoaFisica";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(GePessoaFisicaPermissions));
    }
}
