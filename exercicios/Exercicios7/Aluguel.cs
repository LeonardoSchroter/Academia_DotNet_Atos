using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO_classes_criadas
{
    internal class Aluguel
    {
        public Cliente cliente;
        private double valor;
        public Carro carro;

        public Aluguel(Cliente cliente, double valor, Carro carro)
        {
            this.cliente = cliente;
            this.valor = valor;
            this.carro = carro;
        }

        public double getValor()
        {
            return valor;   
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void mostrarDados()
        {
            Console.WriteLine("Nome do cliente:"+cliente.nome);
            Console.WriteLine("Idade do cliente:" + cliente.idd);
            Console.WriteLine("Modelo do carro:"+ carro.modelo);
            Console.WriteLine("Placa do carro:" + carro.placa);
            Console.WriteLine("Valor do aluguel:"+ valor);

        }

    }
}
