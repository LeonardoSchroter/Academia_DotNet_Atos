using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OO_Encapsulamento
{
    internal class Agenda
    {
        private List <Pessoa> pessoa = new List<Pessoa>();



        public void armazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa p = new Pessoa(nome, altura, idade);
            this.pessoa.Add(p);

        }
        
        public void removePessoa(string nome)
        {
            
            for(int i = 0; i < pessoa.Count; i++)
            {
                if (pessoa[i].Nome.Equals(nome))
                {
                    pessoa.RemoveAt(i);
                }
            }
                
            

        }
        public Pessoa buscaPessoa(string nome)
        {
            Pessoa r = null;
            foreach (Pessoa c in pessoa)
            {
                if (c.Nome.Equals(nome))
                {
                    r = c;
                }
            }
            return r;
        }




        public void imprimeAgenda()
        {

            for(int i = 0; i < pessoa.Count; i++)
            {
                Console.WriteLine("Pessoa " + i + ": " + pessoa[i].Nome + " Altura: " + pessoa[i].Altura+ " Idade: " + pessoa[i].Idade );
            }



        }

    }
}
