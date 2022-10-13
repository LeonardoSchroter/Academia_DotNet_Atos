using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("webOS iniciando");
            this.ligado = true;
        }
    }
}
