using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Encapsulamento
{
    internal class Conta
    {

        public Cliente cliente;
        private double saldo= 0;
        public string tipo = "corrente";

        public Conta(Cliente cliente, double saldo, string tipo)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }

        public void creditar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Creditado " + valor );
        }

        public void debitar(double valor)
        {
            saldo -= valor;
            Console.WriteLine("Debitado " + valor);
        }

        public double getSaldo()
        {
            return saldo;
        }


    }
}
