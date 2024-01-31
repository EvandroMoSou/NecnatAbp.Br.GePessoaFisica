using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NecnatAbp.Br.GePessoaFisica
{
    public enum TipoPessoaFisicaEmail
    {
        [Description("Não Informado")]
        NaoInformado = 0,

        [Description("Pessoal")]
        Pessoal = 1,

        [Description("Comercial")]
        Comercial = 2,

        [Description("Contato")]
        Contato = 3,
    }
}
