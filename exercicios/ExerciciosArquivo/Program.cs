using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ExerciciosArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Fazer um programa em VS que popule uma lista e um arquivo .csv de nomes, com nomes completos obrigatoriamente.
            //Ao cadastrar o nome na lista e no arquivo, o nome deve ser validado para que tenha no mínimo duas palavras e
            //que não esteja na lista. Ao final, caso o nome não esteja na lista e arquivo, cadastra-lo em maiúsculo e
            //exibir a lista ordenada.







            string nome;
            int op;
            Util util = new Util();
            List<Nomes> lista = new List<Nomes>();



            StreamReader reader = new StreamReader(@"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\ExercicioArquivos1.txt");

            while (!reader.EndOfStream)
            {
                nome = reader.ReadLine();
                lista.Add(new Nomes(nome));
            }

            reader.Close();
            while (true)
            {
                Console.WriteLine("Deseja cadastrar algum nome no arquivo?(1 para sim e 2 para nao)");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    do
                    {
                        Console.WriteLine("Qual nome deseja registrar?");
                        nome = Console.ReadLine();
                        nome = nome.ToUpper();
                        if (util.ValidaNome(nome) && util.ConfereExistencia(nome, lista))
                        {
                            break;
                        }



                    } while (true);
                    lista.Add(new Nomes(nome));

                    StreamWriter writer = new StreamWriter(@"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\ExercicioArquivos1.txt", append: true);

                    writer.Write(nome + "\n");

                    writer.Close();
                }
                else break;

            }


            util.ListaOrdenadaPorNome(lista);

            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
            }
            */

            //            2.Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            //Os emails digitados devem ser cadastrados em uma lista e depois em um arquivo.csv e não pode haver emails duplicados, 
            //ou seja, o programa deve controlar essa situação.Quando o usuário solicitar a listagem dos emails, além dessa
            //lista, o programa deve listar os domínios de emails cadastrados no programa.

            //Menu
            //1 - Cadastrar email
            //2 - Listar
            //3 - Sair
            //Opção:





        }
    }
}