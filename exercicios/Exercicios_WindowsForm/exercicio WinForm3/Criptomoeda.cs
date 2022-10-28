using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_WinForm3
{
    internal class Criptomoeda
    {
        public string Sigla {get; set;}
        public string Nome {get; set;}

        public float Preco { get; set; }

        public Criptomoeda(string sigla, string nome, float preco)
        {
            Sigla = sigla;
            Nome = nome;
            Preco = preco;
        }

       
    }
}
