using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO_classes_criadas
{
    internal class Cliente
    {
        public string nome;
        public int idd;

        public Cliente(int idd, string nome)
        {
            this.idd = idd;
            this.nome = nome;
        }
    }
}
