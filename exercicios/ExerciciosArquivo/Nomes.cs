using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosArquivo
{
    internal class Nomes
    {
        private string nome;


        public Nomes(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
    }
}
