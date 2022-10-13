using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Pessoas
    {
        public Pessoas() { }
        public string Nome {get;set; }
        public int Idade {get;set; }

        public Pessoas(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
