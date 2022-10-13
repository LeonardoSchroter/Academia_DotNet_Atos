using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract class Eletronico
    {
        private int _volts;
        private int _potencia;
        private bool _ligado;


        public bool ligado
        {
            get => _ligado; 
            set => _ligado = value; 
        }
        public abstract void Ligar();

        public void Desligar()
        {
            _ligado= false;
            Console.WriteLine("Desligando o equipamento");
        }

        


    }
}
