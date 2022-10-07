using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Encapsulamento
{
    public class Carro
    {
        public double valocidadeMaxima;
        private string modelo;
        public string placa; public int MyProperty { get; set; }
        public string fabricante;
        private bool ligado= false;

        private string cor;

        public string Modelo { get => modelo; set => modelo = value; }

        public string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }
        
        
        //getter e setter

        public bool getLigado()
        {
            return ligado;
        }





        public Carro(double valocidadeMaxima, string modelo, string cor, string placa, string fabricante, bool ligado)
        {
            this.valocidadeMaxima = valocidadeMaxima;
            this.Modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.fabricante = fabricante;
            this.ligado = ligado;    //this é usado para especificar que a variavel se refere ao conteúdo da classe(atributo).
        }   
        //public Carro()
        //{

        //}
        //public Carro(string modelo)
        //{
        

        //}
        //Sobrecarga é feita quando ha mais de um construtor, consequentemente mais de uma forma de instanciar o objeto
        public void ligar()
        {
            ligado = true;
            Console.WriteLine("O carro foi ligado");
        }

        public void desligar()
        {
            ligado=false;
            Console.WriteLine("O carro foi desligado");
        }


    }
}
