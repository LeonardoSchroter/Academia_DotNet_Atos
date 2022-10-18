using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO_classes_criadas
{
    internal class Carro
    {
        public string modelo;
        public string placa;

        public Carro(string modelo, string placa)
        {
            this.modelo = modelo;
            this.placa = placa;
        }
    }
}
