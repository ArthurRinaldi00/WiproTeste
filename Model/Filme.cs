using System;

namespace wiproTeste.Model
{
    public class Filme
    {
        public string IdFilme { get; set; } = Guid.NewGuid().ToString();
        public string Titulo { get; set; }
    }
}