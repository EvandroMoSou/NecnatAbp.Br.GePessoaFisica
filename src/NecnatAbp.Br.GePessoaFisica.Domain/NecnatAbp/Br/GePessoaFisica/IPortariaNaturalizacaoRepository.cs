using System;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GePessoaFisica
{
    public interface IPortariaNaturalizacaoRepository : IRepository<PortariaNaturalizacao, Guid>
    {
    }
}
