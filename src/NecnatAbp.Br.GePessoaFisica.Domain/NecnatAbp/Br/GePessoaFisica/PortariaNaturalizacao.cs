using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class PortariaNaturalizacao : AuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; } = string.Empty;
    }
}
