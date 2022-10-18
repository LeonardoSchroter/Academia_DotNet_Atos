using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_dicionario
{
    internal class Personagem
    {
        private string _Nome;
        private int _Poder;



        public Personagem(string nome, int poder)
        {
            _Nome = nome;
            _Poder = poder;
        }
        public Personagem()
        {
        
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public int Poder
        {
            get { return _Poder; }
            set { _Poder = value; }
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + _Nome+"\nPoder: "+_Poder) ;
        }


    }
}
