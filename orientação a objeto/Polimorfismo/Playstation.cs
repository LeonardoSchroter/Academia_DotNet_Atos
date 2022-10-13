using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Playstation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Playstation iniciando");
            this.ligado = true;
        }
    }
}
