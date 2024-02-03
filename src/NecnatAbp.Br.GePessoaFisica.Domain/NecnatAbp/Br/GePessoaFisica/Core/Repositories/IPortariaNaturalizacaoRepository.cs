using System;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GePessoaFisica
{
    public partial interface IPortariaNaturalizacaoRepository : IRepository<PortariaNaturalizacao, Guid>
    {
    }
}
