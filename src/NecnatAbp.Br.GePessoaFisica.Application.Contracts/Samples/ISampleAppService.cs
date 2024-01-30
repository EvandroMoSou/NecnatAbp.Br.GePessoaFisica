using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace NecnatAbp.Br.GePessoaFisica.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
