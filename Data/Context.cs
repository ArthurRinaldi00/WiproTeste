using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Model;

namespace wiproTeste.Data
{
    public class Context
    {
        public static List<Cliente> Clientes = new List<Cliente> { 
                new Model.Cliente {
                Id = "73c0c202-a269-44de-93f0-567993008452",
                Nome = "Arthur",
                Cpf = "1"},
               
                new Model.Cliente {
                Id = "816e9558-0836-4029-a125-882179311b7b",
                Nome = "Rinaldi",
                Cpf = "2"}
        };


        public static List<Filme> Filmes = new List<Filme> { 
                new Model.Filme {
                IdFilme = "947eb10c-37d0-4b01-923e-9822e4904209",
                Titulo = "Batman"},

               new Model.Filme {
                IdFilme = "4d101c6b-5eb0-4d21-90c7-dc90c8f64eb7",
                Titulo = "Minions" }
        };

        public static List<Locacao> locacoes = new List<Locacao> { 
                new Model.Locacao {
                idLocacao = "947eb10c-37d0-4b01-923e-9822e4904209",
                DataLocacao = DateTime.Today,
                DataEsperadaDevolucao = new DateTime(2022,07,26),
                DataDevolucao = new DateTime(2022,07,26),
                IdFilme = "947eb10c-37d0-4b01-923e-9822e4904209",
                IdCliente = "73c0c202-a269-44de-93f0-567993008452"
                }
        };

        public static object Locacao { get; internal set; }
    }
}
