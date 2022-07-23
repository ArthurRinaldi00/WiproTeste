using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Data;
using wiproTeste.Model;

namespace wiproTeste.Repositories
{
    public interface IClienteRepository
    {
        void Add(Cliente entity);
        IEnumerable<Cliente> GetCliente();
        Cliente GetCliente(string IdCliente);

        bool ClienteExistente(Cliente entity);
    }



    public class ClienteRepository : IClienteRepository
    {
        public void Add(Cliente entity)
        {
            Context.Clientes.Add(entity);
        }

        public bool ClienteExistente(Cliente entity)
        {
            var Cli = Context.Clientes.Any(x => x.Cpf == entity.Cpf);
            return Cli;
        }

        public IEnumerable<Cliente> GetCliente()
        {
            return Context.Clientes;
        }

        public Cliente GetCliente(string IdCliente)
        {
            var Cli = Context.Clientes.Where(x => x.Id == IdCliente).FirstOrDefault();
            return Cli;
        }

    }
}
