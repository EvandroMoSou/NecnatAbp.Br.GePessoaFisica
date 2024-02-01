﻿using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class PisPasepNisNitDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? PessoaFisicaId { get; set; }
        public string? Numero { get; set; }
    }
}