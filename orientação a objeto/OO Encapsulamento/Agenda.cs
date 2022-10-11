using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OO_Encapsulamento
{
    internal class Agenda
    {
        private Pessoa[] pessoa;

        public Agenda(Pessoa[] pessoa)
        {
            this.pessoa = pessoa;
        }

        public void armazenaPessoa(string nome, int idade, float altura, Pessoa[] pessoa, int qtd)
        {
           

            bool encontrei = false;
            
                    pessoa[i].Nome = nome;
                    pessoa[i].Idade = idade;
                    pessoa[i].Altura = altura;
                    encontrei = true;
                    Console.WriteLine("A pessoa foi colocada na agenda");
                    break;
                }
            }
            if (!encontrei)
            {
                Console.WriteLine("A agenda já está cheia");
            }




        }
        public void removePessoa(string nome, Pessoa[] pessoa)
        {
            bool encontrei = false;
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i].Nome == nome)
                {
                    pessoa[i].Nome = "";
                    pessoa[i].Idade = 0;
                    pessoa[i].Altura = 0;
                    encontrei = true;
                    Console.WriteLine("Pessoa removida");
                    break;
                }
            }
            if (!encontrei)
            {
                Console.WriteLine("Esta pessoa nao esta na lista");
            }

        }
        public void buscaPessoa(string nome, Pessoa[] pessoa)
        {
            bool encontrei = false;
            for (int i = 0; i < 10; i++)
            {
                if (pessoa[i].Nome == nome)
                {
                    Console.WriteLine(pessoa[i].Nome + " idade: " + pessoa[i].Idade + " altura:" + pessoa[i].Altura);
                    break;
                }

            }
            if (!encontrei)
            {
                Console.WriteLine("Pessoa não encontrada");
            }
        }




        public void imprimeAgenda(Pessoa[] pessoa)
        {
            if (pessoa.Length == 0)
            {
                Console.WriteLine("Agenda vazia");
            }
            for (int i = 0; i < 10; i++)
            {

                if (pessoa[i].Nome == "")
                {
                    continue;
                }
                Console.WriteLine("posição: " + i + "\n nome: " + pessoa[i].Nome + " \nidade: " + pessoa[i].Idade + " \naltura: " + pessoa[i].Altura);
                break;



            }
        }

    }
}
