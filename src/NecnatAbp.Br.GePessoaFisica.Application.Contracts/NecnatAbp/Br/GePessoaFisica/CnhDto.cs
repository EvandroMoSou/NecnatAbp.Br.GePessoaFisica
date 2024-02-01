using NecnatAbp.Br.GeGeocodificacao;
using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GePessoaFisica
{
    public class CnhDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? PessoaFisicaId { get; set; }
        public string? Numero { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataValidade { get; set; }
        public UnidadeFederativa? UnidadeFederativa { get; set; }
    }
}
