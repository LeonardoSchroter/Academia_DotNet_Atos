using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Televisao : IEletronico
    {
        private int _volts;
        private int _potencia;
        private bool _ligado;


        public bool Ligado
        {
            get => _ligado;
            set => _ligado = value;
        }

        public void Ligar()
        {
            Console.WriteLine("WebOS iniciando");
            //_ligado = true;
            Ligado = true;
        }

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o equipamento");
        }
    }
}
