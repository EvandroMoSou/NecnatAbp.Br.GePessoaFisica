using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class PortariaNaturalizacaoDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Nome { get; set; }
    }
}
