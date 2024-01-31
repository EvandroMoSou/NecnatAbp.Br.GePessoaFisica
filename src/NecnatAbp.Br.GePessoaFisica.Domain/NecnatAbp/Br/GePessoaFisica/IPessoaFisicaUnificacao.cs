using System;

namespace NecnatAbp.Br.GePessoaFisica
{
    public interface IPessoaFisicaUnificacao<TKey> where TKey : struct
    {
        TKey PessoaFisicaId { get; set; }
        TKey? PessoaFisicaIdUnificacao { get; set; }
    }
}
