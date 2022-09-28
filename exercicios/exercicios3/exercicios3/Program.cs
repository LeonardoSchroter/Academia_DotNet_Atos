using System;
using System.Diagnostics;

namespace exercicios3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*exercicio aula
            int c = 0;
            for(int i=56; i < 127; i++)
            {
                c=c+i;
            }
            Console.WriteLine(c);
            */

            /*exercicio2 aula

            int c = 0;
            for (int i = 56; i < 127; i++)
            {
                if (i % 2 == 0)
                {
                    c++;
                }
                
            }
            console.writeline(c);

            */

            /*exercicio3 aula

            int impares = 0;
            int soma=0;
            for (int i = 56; i < 127; i++)
            {
                if (i % 2 == 0)
                {
                    soma = i + soma;
                    
                }
                else
                {
                    impares++;
                }
               

            }
            Console.WriteLine("soma dos pares: " + soma + " contagem impares: " + impares);

            */

            /*exercicio4 aula

            int impares = 0;
            int soma = 0;
            int vinicial, vfinal;

            Console.WriteLine("qual valor deseja comecar e em qual deseja terminar");
            vinicial=int.Parse(Console.ReadLine());
            vfinal=int.Parse(Console.ReadLine());

            if (vinicial < vfinal) { 
                for (int i= (vinicial+1); i < vfinal; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma = i + soma;

                    }
                    else
                    {
                        impares++;
                    }


                }
            }
            else
            {
                for (int i=(vinicial-1); i > vfinal; i--)
                {
                    if (i % 2 == 0)
                    {
                        soma = i + soma;

                    }
                    else
                    {
                        impares++;
                    }


                }

            }
            Console.WriteLine("soma dos pares: " + soma + " contagem impares: " + impares);



            */
            /*exercicio5 aula

            int valor,c=0;

            do
            {
                Console.WriteLine("digite um valor, quando um negativo ser digitado,ira parar \n");
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0 && valor>0)
                {
                    c++;
                }
            } while (valor >= 0);

            Console.WriteLine(c+ " valores pares digitados");
            */

            /*exercicio1 

            int valor;

            do
            {
                Console.WriteLine("escreva um valor maior do que 1");
                valor = int.Parse(Console.ReadLine());
            } while (valor < 1);

            for(int i = 2; i < valor; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            */

            /*exercicio2

            int valor;
            string condicao;
            do
            {
                do
                {
                    Console.WriteLine("escreva um numero inteiro positivo");
                    valor = int.Parse(Console.ReadLine());
                    if (valor < 0)
                    {
                        Console.WriteLine("incorreto");
                    }
                    else
                    {
                        Console.WriteLine("valor digitado: " + valor);
                    }
                } while (valor < 0);

                Console.WriteLine("numeros iteiros pares entre 1 e " + valor);

                for (int i = 2; i < valor; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("gostaria de digitar outro numero?['s' ou 'n']");
                condicao = Console.ReadLine();
            } while (condicao != "n");

            */


            /*exercicio3
            int num;
            do
            {
                do {
                    Console.WriteLine("digite um numero diferente e maior que 0");
                    num = int.Parse(Console.ReadLine());
                } while (num < 0);

                int primo = 0;

                for(int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        primo++;
                    }
                }
                if (num % 2 == 0)
                {
                    Console.WriteLine("o numero eh par");
                }
                else
                {
                    Console.WriteLine("o numero eh impar");
                }
                if (primo == 2)
                {
                    Console.WriteLine("o numero eh primo");
                }
                else
                {
                    Console.WriteLine("o numero nao eh primo");
                }


            } while (num != 0);

            */

            /*exercicio4

            int brancos = 0, joao=0, zeca=0;
            string voto= "";

            do
            {
                Console.WriteLine("Em quem quer votar?(se deseja fechar o programa, digite fim).");
                voto= Console.ReadLine();
                voto = voto.ToUpper();

                if (voto == "JOAO")
                {
                    joao++;
                }
                else if (voto == "ZECA")
                {
                    zeca++;
                }
                else if (voto == "BRANCO")
                {
                    brancos++;
                }
                
                

            } while (voto != "FIM");

            Console.WriteLine("Joao: "+joao+"\nZeca: "+zeca +"\nbrancos: "+brancos);

            */

            /*exercicio5

            int brancos = 0, joao = 0, zeca = 0, nulos=0,pessoas=0;
            string voto = "";
            for(; ; ) { 
           
                Console.WriteLine("Em quem quer votar?(se deseja fechar o programa, digite fim).");
                voto = Console.ReadLine();
                voto = voto.ToUpper();

                if (voto == "JOAO")
                {
                    joao++;
                    pessoas++;
                }
                else if (voto == "ZECA")
                {
                    zeca++;
                    pessoas++;
                }
                else if (voto == "BRANCO")
                {
                    brancos++;
                    pessoas++;
                }
                else if (voto == "FIM")
                {
                    break;
                }
                else
                {
                    nulos++;
                    pessoas++;
                }
            }


            if (joao > zeca)
            {
                Console.WriteLine("joao ganhou");
            }
            else if (zeca > joao)
            {
                Console.WriteLine("zeca ganhou");
            }
            Console.WriteLine("Joao: " + joao + "\nZeca: " + zeca + "\nbrancos: " + brancos+ "\nnulo:"+nulos);
            Console.WriteLine("total de pessoas que votaram: "+pessoas);

            */

            /*exercicio6

            int idade=0;

            Console.WriteLine("digite sua idade");

            while (idade <= 0)
            {
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("idade digitada: "+idade);

            */

            /*exercicio7

            bool fechamento = false;
            int idade,salario;
            string nome;

           
            Console.WriteLine("qual a sua idade?");
            idade=int.Parse(Console.ReadLine());
            if (idade <= 0)
                {
                    Console.WriteLine("o valor esta incorreto");
                    fechamento = true;
                    Environment.Exit(0);
                }
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();
            if (nome == "")
                {
                Console.WriteLine("o valor esta incorreto");
                fechamento = true;
                Environment.Exit(0);
            }
                Console.WriteLine("digite seu salario");
                salario = int.Parse(Console.ReadLine());

            if (salario <= 0)
            {
                Console.WriteLine("o valor esta incorreto");
                fechamento = true;
                Environment.Exit(0);
            }
            Console.WriteLine("nome digitado: "+nome+"\nidade digitada: "+idade+"\nsalario digitado: "+salario);

            */


            /*exercicio8

            double num=0 ;
            string fechamento="n";
            do
            {
                do
                {
                    Console.WriteLine("digite um numero inteiro");
                    num = double.Parse(Console.ReadLine());


                } while (num % 1 != 0);

                if (num % 2 == 0)
                {
                    Console.WriteLine("o numero eh par");
                }
                else
                {
                    Console.WriteLine("o nmumero eh impar");
                }

                Console.WriteLine("voce quer fechar o programa['s' ou 'n']");
                fechamento= Console.ReadLine();

            } while (fechamento == "n");

            */

            /*exercicio9

            int filhos, um_tres = 0, quatro_sete = 0, oito_mais = 0, nenhum = 0;

            for(int i = 0; i < 30; i++)
            {
                Console.WriteLine("quantos filhos voce tem?");
                filhos=int.Parse(Console.ReadLine());

                if (filhos >= 8)
                {
                    oito_mais++;
                    continue;
                }
                else if (filhos >= 4)
                {
                    quatro_sete++;
                }
                else if (filhos >= 1)
                {
                    um_tres++;
                }
                else
                {
                    nenhum++;   
                }
            }

            Console.WriteLine("nenhum: "+nenhum+"\nde um a tres: "+um_tres+"\nde quatro a sete:"+quatro_sete+"\noito pra cima:"+oito_mais);

            */

            /*exercicio10

            int mulheres = 0, homens = 0, idade, menos_trinta = 0, mais_sessenta = 0, media=0;
            string genero;

           

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("qual seu sexo?[m ou f]");
                genero = Console.ReadLine();
                if (genero == "f")
                {
                    mulheres++;
                    Console.WriteLine("qual sua idade");
                    idade=int.Parse(Console.ReadLine());
                    if (idade < 30)
                    {
                        menos_trinta++;
                        media = idade + media;
                    }
                    else if (idade > 60)
                    {
                        mais_sessenta++;
                        media = idade + media;
                    }
                    else
                    {
                        media = idade + media;
                    }
                }
                else if(genero == "m")
                {
                    homens++;
                    Console.WriteLine("qual sua idade");
                    idade = int.Parse(Console.ReadLine());
                    if (idade < 30)
                    {
                        menos_trinta++;
                       
                    }
                    else if (idade > 60)
                    {
                        mais_sessenta++;
                        
                    }

                }
                else
                {
                    Console.WriteLine("digite uma letra correta");
                    i--;
                }
            }
            media = media / mulheres;
            Console.WriteLine("pessoas do sexo masculino: "+homens+ "\npessoas do sexo feminino: "+mulheres+"\npessoas com idade inferior a 30: "+menos_trinta+"\npessoas com idade superior a 60: "+mais_sessenta+"\nmedia de idade das mulheres: "+media);

            */

            //exercicio11











        
            








        }
    }
}