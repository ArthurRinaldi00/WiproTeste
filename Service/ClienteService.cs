using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Model;
using wiproTeste.Repositories;

namespace wiproTeste.Service
{
    public interface IClienteService
    {
        void Add(Cliente entity);
        IEnumerable<Cliente> GetCliente();
        Cliente GetCliente(string IdCliente);
        bool Desativacao(string IdCliente);
    }

    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository clienteRepo;
        public ClienteService()
        {
            clienteRepo = new ClienteRepository();
        }

        public void Add(Cliente entity)
        {
            if (string.IsNullOrEmpty(entity.Nome))
            {
                throw new Exception("Nome Nulo");
            }

            if (clienteRepo.ClienteExistente(entity)) 
            {
                throw new Exception("Usuario ja cadastrado");
            }
            clienteRepo.Add(entity);
        }

        public IEnumerable<Cliente> GetCliente()
        {
            return clienteRepo.GetCliente();
        }

        public Cliente GetCliente(string IdCliente)
        {
          return clienteRepo.GetCliente(IdCliente);
        }

        public bool Desativacao(string IdCliente)
        {
            return clienteRepo.Delete(IdCliente);
        }
    }
}
