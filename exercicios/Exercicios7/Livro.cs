using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO_classes_criadas
{
    internal class Livro
    {
        private int qtdPaginas;
        private string titulo;
        private string autor;

        public Livro(int qtdPaginas, string titulo, string autor )
        {
            this.qtdPaginas = qtdPaginas;
            this.titulo = titulo;
            this.autor = autor;


        }

        public void MostrarDados()
        {
            Console.WriteLine("Paginas: "+qtdPaginas + "\nTitulo: "+ titulo+ "\nAutor: "+autor );
        }


    }
}
