using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class PessoaFisicaEmailDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? PessoaFisicaId { get; set; }
        public Guid? PessoaFisicaIdUnificacao { get; set; }
        public TipoPessoaFisicaEmail? TipoPessoaFisicaEmail { get; set; }
        public string? Email { get; set; }
        public bool? RecebeNotificacoes { get; set; }
        public bool? InPrincipal { get; set; }
    }
}
