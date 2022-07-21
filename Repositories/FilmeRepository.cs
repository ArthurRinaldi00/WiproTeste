using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Model;

namespace wiproTeste.Repositories
{
    public class FilmeRepositorie
    {
        public interface IFilmeRepositorie
        {
            void Add<T>(T entity) where T : class;
            Task<bool> SaveAllAsync();
            IEnumerable<Filme> GetFilme();
            Filme GetFilme(int IdFilme);
        }
    }
}
