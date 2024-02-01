using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class CnsDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? PessoaFisicaId { get; set; }
        public TipoCns? TipoCns { get; set; }
        public string? Numero { get; set; }
    }
}
