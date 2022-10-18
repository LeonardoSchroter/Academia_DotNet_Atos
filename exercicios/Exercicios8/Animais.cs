using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_dicionario
{
    internal class Animais
    {
        private string _Nome;
        private string _Tipo;

        public Animais(string nome, string tipo)
        {
            _Nome = nome;
            _Tipo = tipo;
        }
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }

        }
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
    }
}
