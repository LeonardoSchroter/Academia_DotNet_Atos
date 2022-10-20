using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosArquivo
{
    internal class Util
    {
        public bool ValidaNome(string nome)
        {
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] == ' ' && (nome[i + 1] != ' ' || nome[i + 1] != '\n'))
                {

                    return true;
                }
            }
            Console.WriteLine("Escreva o nome completo");
            return false;
        }
        public bool ConfereExistencia(string nome, List<Nomes> lista)
        {
            foreach (var item in lista)
            {
                if (item.Nome == nome)
                {
                    Console.WriteLine("Nome ja cadastrado");
                    return false;
                }
            }
            return true;
        }

        public void ListaOrdenadaPorNome(List<Nomes> lista)
        {
            Console.WriteLine("Lista ordenada por nome");
            lista.Sort(delegate (Nomes p1, Nomes p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
           
        }

    }


}
