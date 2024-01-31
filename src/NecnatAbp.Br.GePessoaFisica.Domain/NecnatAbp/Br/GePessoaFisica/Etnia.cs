using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class Etnia : AuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; } = string.Empty;
    }
}
