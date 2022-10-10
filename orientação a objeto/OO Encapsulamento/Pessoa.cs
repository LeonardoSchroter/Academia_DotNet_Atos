using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Encapsulamento
{
    internal class Pessoa
    {
        private string pai;
        private string mae;
        private string nome;
        private float altura;
        private float peso;
        private int idade;

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Altura { get => altura; set => altura = value; }

        public void setPai(string pai)
        {
           this.pai = pai;
        }

        public void setMae(string mae)
        {
            this.mae = mae;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setAltura(float altura)
        {
            this.Altura = altura;   
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }


    }
}
