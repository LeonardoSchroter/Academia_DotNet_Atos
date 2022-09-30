using System.Runtime.Intrinsics.X86;

namespace exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Exemplo vetores
            int[] b = new int[5];

            Console.WriteLine("------------Leitura dos valores-----------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor "+ i +":");
                b[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor indice "+i+" é igual a "+ b[i]);
            }

            */

            /*exemplo 2

            double[] notas = new double[50];
            double media=0;
            
            
            Console.WriteLine("---------Leitura de valores---------");
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite a nota do aluno:"+i+":");
                notas[i]=double.Parse(Console.ReadLine());
                media=media+notas[i];
            }
            media=media / 50;

            Console.WriteLine("------Mostra da media------");
            Console.WriteLine("A medida das notas é igual a :"+media);


            */

            /*exercicio aula
            int[] vetor = new int[10];
            int menor;

            Console.WriteLine("Digite o valor do vetor");
            for(int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            menor = vetor[0];

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                
                }
            }
            Console.WriteLine("O menor vetor é:" + menor  );

            */

            /*1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int[] vetor = new int[10];
            int par = 0, impar = 0;

            for(int i= 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor para o vetor["+i+"]");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Pares:"+par+"\nimpar:"+impar);

            */

            /*2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a
            //soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            int[] vetorA = new int[20], vetorB = new int[20], vetorC = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o vetor[" + i + "]");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o vetor[" + i + "]");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
                Console.WriteLine("VetorC[" + i + "]= " + vetorC[i]);
            }
            */

            /*3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela
            //o índice da posição dos valores correspondentes a números primos.
            int[] vetorA = new int[20], vetorP = new int[20];
            int primos=0;
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o vetorA[" + i + "]");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = 1; j <= vetorA[i]; j++)
                {
                    if (vetorA[i] % j == 0)
                    {
                        primos++;
                    }

                }
                if (primos <=2)
                {
                    Console.WriteLine("o numero na posicao "+i+" é primo");
                }
                primos = 0;
            }

            */

            /*4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
            //colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            int[] vetorA = new int[20], vetorB = new int[20], vetorC = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o vetor[" + i + "]");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o vetor[" + i + "]");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                vetorC[i] = vetorA[i] * vetorB[i];
                Console.WriteLine("VetorC[" + i + "]= " + vetorC[i]);
            }
            */

            /*5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
            int[] vetor = new int[10];
            int menor, pos=0;

            Console.WriteLine("Digite o valor do vetor");
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            menor = vetor[0];

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    pos = i;
                }
            }
            Console.WriteLine("O menor vetor é:" + menor+ "\nposicao:"+pos);

            */

            /*6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int[] vetor = new int[10];
            Console.WriteLine("Escreva o valor dos vetores");
            for(int i = 0; i < 10; i++)
            {
                vetor[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }

            */

            /*7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            // a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int[] vetor = new int[10];
            int aux,c=0;
            Console.WriteLine("Escreva o valor dos vetores");
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i]%2== 0)
                {
                    aux = vetor[c];
                    vetor[c] = vetor[i];
                    vetor[i] = aux;
                    c++;
                }
                
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("vetor[" + i + "]=" + vetor[i]);
            }

            */

            /*8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
            //a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            int[] vetor = new int[10], vetorB=new int[10];
            int aux, c = 0;
            Console.WriteLine("Escreva o valor dos vetores");
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i]<0)
                {
                    vetorB[c] = i;
                    c++;
                }

            }
            for (int i = 0; i <c; i++)
            {
                Console.WriteLine("Os valores sao menores do que 0 nas posicoes:" + vetorB[i]);
            }
            */

            /*9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente
            //os valores desse vetor, utilizando um vetor auxiliar.

            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite os valores para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(vetor);
            Console.Write("\n\n");
            foreach (int i in vetor) Console.WriteLine(i);

            /*10-Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor,
            //substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.


            int[] vetorA = new int[20], vetorB = new int[20];
            int c=0;
            Console.WriteLine("Escreva o valor dos vetores");
            for (int i = 0; i < 20; i++)
            {
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < 20; i++)
            {
                if (vetorA[i] == 0)
                {
                    vetorB[i] = 2;
                }
                else
                {
                    vetorB[i] = vetorA[i];
                }
            }
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorB[i]);
            }

            */
            /*11.	Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int[] vetorA = new int[5];
            
            Console.WriteLine("Escreva o valor dos vetores");
            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 4; i >= 0; i--)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorA[i]);
            }
            */

            /*12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N,
            //fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão
            //escrever a mensagem "O número fornecido não existe no vetor!".

            int[] vetorA = new int[10];
            int n,ind=0;
            bool encontrei = false;
            Console.WriteLine("Escreva o valor dos vetores");
            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite um numero");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                if(n== vetorA[i])
                {
                    encontrei = true;
                    ind = i;
                }
            }
            if (encontrei)
            {
                Console.WriteLine("o numero existe dentro do vetor, na posição: "+ind);
            }
            else
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
            */

            /*13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números
            //2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.


            int[] vetorA = new int[10];
            int c = 0;
            string num;

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Quer escrever no vetor?(Se não quiser, digite -1");
                num=Console.ReadLine();
                if (num == "-1")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um numero para a posição "+i);
                    vetorA[i] = int.Parse(Console.ReadLine());
                    if (vetorA[i]==2 || vetorA[i]==4 || vetorA[i] == 8)
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine("Os numeros 2,4 e 8 apareecem "+c+ " vezes");

            */

            /*14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero,
            //termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor
            //na ordem inversa, do último elemento até o primeiro.

            int cod;
            int[] vetor = new int[50];

            Console.WriteLine("Escreva o vetor");
            for(int i=0; i < 50; i++)
            {
                vetor[i]=int.Parse(Console.ReadLine());
            }

            do
            {
                Console.Clear();
                Console.WriteLine("O que deseja fazer?\n[0]Para encerrar o algoritmo \n[1]Para ler o vetor\n[2]Para ler o vetor na ordem inversa");
                cod=int.Parse(Console.ReadLine());

                if (cod == 1)
                {
                    for(int i = 0; i < 50; i++)
                    {
                        Console.WriteLine("vetor [" + i + "] = " + vetor[i]);
                    }
                }
                else if (cod == 2)
                {
                    for (int i = 49; i >= 0; i--)
                    {
                        Console.WriteLine("vetor [" + i + "] = " + vetor[i]);
                    }
                }
                Console.WriteLine("Pressione enter ou qualquer tecla para continuar");
                Console.ReadKey();
            } while (cod != 0);

            */

            /*15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos
            //para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último
            //elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.]

            int[] vetorA = new int[20], vetorB = new int[20];
            int c = 0;
            Console.WriteLine("Digite os valores do primeiro vetor");
            for(int i=0; i < 20; i++)
            {
                vetorA[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 19; i >= 0; i--)
            {
                vetorB[c] = vetorA[i];
                c++;
            }
            Console.WriteLine("-----------Primeiro vetor-------------");
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorA[i]);
            }
            Console.WriteLine("-----------Segundo vetor-------------");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorB[i]);
            }

            */

            /*16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.

            double[] vetorA = new double[10], vetorB = new double[10], vetorU = new double[20], vetorD = new double[10], vetorI = new double[10];
            int c = 0, cont = 0;
            Console.WriteLine("Escreva os valores para o primeiro vetor");
            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Escreva os valores para o segundo vetor");
            for (int i = 0; i < 10; i++)
            {
                vetorB[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    vetorU[i] = vetorA[cont];
                    cont++;
                }
                else
                {
                    vetorU[i] = vetorB[c];
                    c++;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                vetorD[i] = (vetorA[i] - vetorB[i]);
            }
            c = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (vetorA[i] == vetorB[j])
                    {
                        vetorI[c] = vetorA[i];
                        c++;
                    }
                }
            }
            Console.WriteLine("-------Mostrando vetor com a uniao de A e B--------");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorU[i]);
            }



            Console.WriteLine("-------Mostrando vetor com a diferença de A e B--------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vetor [" + i + "] = " + vetorD[i]);
            }


            if (c != 0)
            {
                Console.WriteLine("-------Mostrando vetor com a intersecção de A e B--------");

                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine("vetor [" + i + "] = " + vetorI[i]);

                }
            }
            else
            {
                Console.WriteLine("a intersecção entre os dois não existe");
            }

            */
        }
    }
}