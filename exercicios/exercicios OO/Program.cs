using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace exercicios_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1.Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
            Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e
             que não esteja na lista.Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e
            exibir a lista ordenada.

            string nome;
            List<string> nomePessoas = new List<string>();

            do
            {
                Console.WriteLine("Digite um nome");
                nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    break;
                }
                if (nomePessoas.Contains(nome))
                {
                    Console.WriteLine("Nome ja cadastrado");
                    continue;
                }
                if (!nome.Contains(" "))
                {
                    Console.WriteLine("Deve haver no minimo duas palavras");
                    continue;
                }

                else
                {
                    nomePessoas.Add(nome);

                }

            } while (true);

            nomePessoas.Sort();

            for (int i = 0; i < nomePessoas.Count; i++)
            {
                Console.WriteLine(nomePessoas[i]);
            }
            */

            /*2.Fazer um programa em VS que popule uma lista com números inteiros(0 a 1000) que sejam sorteados
           //randomicamente.O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
          //deve exibir os números populados na lista.

           Random gerador = new Random();
           List<int> lista = new List<int>();
           int qtdNumeros, num;

           Console.WriteLine("Quantos números deseja armnazenar na lista?");
           qtdNumeros = int.Parse(Console.ReadLine());

           for(int i = 0; i < qtdNumeros; i++)
           {
               num= gerador.Next(0,1000);
               lista.Add(num);
           }
           Console.WriteLine("-----------Numeros da lista-----------");
           for (int i = 0; i < qtdNumeros; i++)
           {

               Console.WriteLine(lista[i]);
           }
            */

            /*3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            //Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
            //o programa deve controlar essa situação.Quando o usuário solicitar a listagem dos emails, além dessa
            //lista, o programa deve listar os domínios de emails cadastrados no programa.

            List<string> listaEmail = new List<string>();
            int num;
            string email;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------Menu-------------------");
                Console.WriteLine("1-Cadastrar email\n2-Listar email\n3-Sair do programa");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Digite o email que quer cadastrar");
                        email = Console.ReadLine();
                        if (listaEmail.Contains(email))
                        {
                            Console.WriteLine("Digite um email que não exista na lista");
                        }
                        else
                        {
                            listaEmail.Add(email);
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        for(int i=0; i < listaEmail.Count; i++)
                        {
                            Console.WriteLine(listaEmail[i]);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Obrigado por usar o programa");
                        break;


                       
                }
            } while (num != 3);
            */

            /*4. Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
            //completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve
            //ser cadastrado(em maiúsculo).Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
            //que a opção listar for acionada, a listagem deve ser exibida de forma ordenada.No processo de
            //remoção, o usuário entra com o nome da criptomoeda que deseja remover.Caso o programa a encontre,
            //deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
            //ao usuário que nome não foi encontrado.

            List<string> listaCriptos = new List<string>();
            int num, ind=0;
            string cripto;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------Menu-------------------");
                Console.WriteLine("1-Inserir\n2-pesquisar\n3-Atualizar\n4-Remover\n5-Sair do programa");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Digite a criptomoeda que quer cadastrar");
                        cripto = Console.ReadLine().ToUpper();
                        if (listaCriptos.Contains(cripto))
                        {
                            Console.WriteLine("Digite uma criptomoeda que não exista na lista");
                        }
                        else
                        {
                            listaCriptos.Add(cripto);
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        for (int i = 0; i < listaCriptos.Count; i++)
                        {
                            Console.WriteLine(listaCriptos[i]);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Qual o nome da criptomoeda que deseja atualizar?");
                        cripto= Console.ReadLine().ToUpper();
                        if (listaCriptos.Contains(cripto))
                        {
                            for(int i = 0; i < listaCriptos.Count; i++)
                            {
                                if (listaCriptos[i] == cripto)
                                {
                                    ind = i;
                                }
                            }
                            Console.WriteLine("Qual o novo nome da criptomoeda?");
                            cripto=Console.ReadLine().ToUpper();
                            listaCriptos[ind] = cripto;
                            Console.WriteLine("Criptomoeda atualizada");

                        }
                        else
                        {
                            Console.WriteLine("Esta criptomoeda não esta cadastrada;");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Qual criptomoeda deseja remover?");
                        cripto = Console.ReadLine().ToUpper();
                        if (listaCriptos.Contains(cripto))
                        {
                            listaCriptos.Remove(cripto);
                            Console.WriteLine("Criptomoeda removida");
                        }
                        else
                        {
                            Console.WriteLine("Esta criptomoeda não esta cadastrada");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Obrigado por usar o programa");
                        break;



                }
            } while (num != 5);

            */

            /*5. Crie um programa em VS que popule duas listas (lista1 e lista2) com números aleatórios (100 a 200).
            // A quantidade de números deve ser informada pelo usuário.Em seguida, o programa deve listar os
            //conteúdos das duas listas e exibir os números que aparecem em ambas as listas.

            Random gerador = new Random();
            List<int> lista1 = new List<int>(), lista2 = new List<int>();
            int qtdNumeros, num;

            Console.WriteLine("Quantos números deseja armnazenar na lista 1?");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdNumeros; i++)
            {
                num = gerador.Next(100, 200);
                lista1.Add(num);
            }
            Console.WriteLine("Quantos números deseja armnazenar na lista 2?");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdNumeros; i++)
            {
                num = gerador.Next(100, 200);
                lista2.Add(num);
            }

            Console.WriteLine("-----------Numeros da lista 1-----------");
            for (int i = 0; i < lista1.Count; i++)
            {

                Console.WriteLine(lista1[i]);
            }
            Console.WriteLine("-----------Numeros da lista 2-----------");
            for (int i = 0; i < lista2.Count; i++)
            {

                Console.WriteLine(lista2[i]);
            }

            Console.WriteLine("-----------Numeros em comum em ambas as listas-----------");

            if (lista1.Count > lista2.Count)
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    for (int j = 0; j < lista2.Count; j++)
                    {
                        if (lista1[i] == lista2[j])
                        {
                            Console.WriteLine(lista1[i]);
                            break;
                        }
                    }
                }
            }
            else if (lista2.Count > lista1.Count)
            {
                for (int i = 0; i < lista2.Count; i++)
                {
                    for (int j = 0; j < lista1.Count; j++)
                    {
                        if (lista1[j] == lista2[i])
                        {
                            Console.WriteLine(lista2[i]);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    for (int j = 0; j < lista2.Count; j++)
                    {

                        if (lista1[i] == lista2[j])
                        {
                            Console.WriteLine(lista1[i]);
                        }
                    }
                }
            }
            */

            /*6. Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
            //Além disso, o programa deve mostrar as pessoas que são da mesma família.

            string nome;
            List<string> nomePessoas = new List<string>();
            string[] sobrenome, sobrenome2;
            do
            {
                Console.WriteLine("Digite um nome");
                nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    break;
                }
                if (nomePessoas.Contains(nome))
                {
                    Console.WriteLine("Nome ja cadastrado");
                    continue;
                }
                if (!nome.Contains(" "))
                {
                    Console.WriteLine("Deve haver no minimo duas palavras");
                    continue;
                }

                else
                {
                    nomePessoas.Add(nome);

                }

            } while (true);

            nomePessoas.Sort();
            Console.WriteLine("-------------Mostrando sobrenomes-------------");
            for (int i = 0; i < nomePessoas.Count; i++)
            {
                sobrenome = nomePessoas[i].Split(" ");
                Console.WriteLine(sobrenome[1]);
            }
            for (int i = 0; i < nomePessoas.Count; i++)
            {
                for (int j = 0; j < nomePessoas.Count; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    sobrenome = nomePessoas[i].Split(" ");
                    sobrenome2 = nomePessoas[j].Split(" ");
                    if (sobrenome[1] == sobrenome2[1])
                    {
                        Console.WriteLine(nomePessoas[i]+" é da mesma familia de " + nomePessoas[j]);
                    }
                }
            }
            */


        }
    }
}