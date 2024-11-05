using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_continuacao
{
    internal class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public Autor autorLivro { get; set; }
        public Livro() { }

        public Livro(string titulo, Autor autor)
        {
            Titulo = titulo;
            autorLivro = autor;
        }

        public override string? ToString()
        {
            return $"Livro -> id: {Id} | Nome: `{Titulo}";
        }
    }
}
