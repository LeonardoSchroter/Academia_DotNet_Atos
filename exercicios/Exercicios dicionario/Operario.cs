using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_dicionario
{
    internal class Operario : Funcionario
    {
        public Operario(string nome, string departamento, double salario, string dataEntrada, string rG, bool ativo) : base(nome, departamento, salario, dataEntrada, rG, ativo)
        {
        }

        public override void Funcao()
        {
            Console.WriteLine("Desempenha a função de operário"); 
        }
    }
}
