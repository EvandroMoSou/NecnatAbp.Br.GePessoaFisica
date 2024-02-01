using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class EtniaDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Nome { get; set; }
    }
}
