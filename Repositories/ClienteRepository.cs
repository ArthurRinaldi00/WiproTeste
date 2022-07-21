using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Model;

namespace wiproTeste.Repositories
{
    public class ClienteRepository
    {
        public interface IClienteRepository
        { 
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAllAsync();
        IEnumerable<Cliente> GetCliente();
        Cliente GetCliente(int IdCliente);
        }
    }
}
