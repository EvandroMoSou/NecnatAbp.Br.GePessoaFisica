using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NecnatAbp.Br.GePessoaFisica
{
    public enum ModeloCertidao
    {
        [Description("Modelo Antigo")]
        Antigo = 1,

        [Description("Modelo Novo")]
        Novo = 2,
    }
}
