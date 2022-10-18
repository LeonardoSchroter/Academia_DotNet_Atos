using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO_classes_criadas
{
    internal class Pessoa
    {
        private double altura;
        private string nome;
        private double peso;
        private int idade;

        public Pessoa(double altura, string nome, double peso, int idd)
        {
            this.altura = altura;
            this.nome = nome;
            this.peso = peso;
            this.idade = idd;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Altura: "+ altura+ "\nNome: "+ nome+"\nIdade: "+idade+ "\nPeso: "+peso+"kg");
        }



    }
}
