﻿using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class OrgaoEmissorDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Sigla { get; set; }
        public string? Nome { get; set; }
        public bool? InAtivo { get; set; }
    }
}
