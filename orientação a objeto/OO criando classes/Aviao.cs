using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_criando_classes
{
    internal class Aviao
    {
        public string Modelo;
        public int Velocidade;
        public int Altitude;
        public string Marca;

        public void Reduzir()
        {
            Velocidade--;
        }

        public void Subir()
        {
            Altitude--;
        }
        public void descer()
        {
            Altitude--;
        }
        public void Acelerar()
        {
            Velocidade++;
        }
    }
}
