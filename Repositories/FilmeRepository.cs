using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wiproTeste.Data;
using wiproTeste.Model;

namespace wiproTeste.Repositories
{
    public interface IFilmeRepository
    {
        void Add(Filme entity);
        IEnumerable<Filme> GetFilme();
        Filme GetFilme(string IdFilme);
    }

    public class FilmeRepository : IFilmeRepository
    {
        public void Add(Filme entity)
        {
            Context.Filmes.Add(entity);
        }

        public IEnumerable<Filme> GetFilme()
        {
            return Context.Filmes;
        }

        public Filme GetFilme(string Titulo)
        {
            var FilmeUnico = Context.Filmes.Where(x => x.Titulo == Titulo).FirstOrDefault();
            return FilmeUnico;
        }
    }
}
