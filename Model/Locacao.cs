using System;
using static wiproTeste.Enum.Enum;

namespace wiproTeste.Model
{
    public class Locacao
    {
        public int id { get; set; }
        public ELocacaoStatus status { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Filme IdFilme { get; set; }
        public Cliente IdCliente { get; set; }

    }
}