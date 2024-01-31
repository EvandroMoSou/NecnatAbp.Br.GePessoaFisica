﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class PisPasepNisNit : AuditedAggregateRoot<Guid>, IPessoaFisicaUnificacao<Guid>
    {
        public Guid PessoaFisicaId { get; set; }
        public PessoaFisica? PessoaFisica { get; set; }
        public Guid? PessoaFisicaIdUnificacao { get; set; }
        public string Numero { get; set; } = string.Empty;
    }
}
