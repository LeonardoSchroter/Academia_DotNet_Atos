using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Encapsulamento
{
    internal class Livro
    {
        private int numPaginas;
        private string nome;
        private string autor;

        public Livro(int numPaginas, string nome, string autor)
        {
            this.NumPaginas = numPaginas;
            this.Nome = nome;
            this.Autor = autor;
        }

        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Autor { get => autor; set => autor = value; }

    }

    
    

}
