using System.Xml;

namespace Exercicios5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Matrizes
            int[,] matriz = new int[3, 3];
            //preencher a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //mostrando o conteúdo da matríz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }

            //Diagonal principal
            Console.WriteLine("-------Mostrando diagonal principal-------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j) { 
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }

            */
            /*1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna.
            //Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matriz = new int[5, 3];

            Console.WriteLine("Prencha a primeira coluna");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("[1,"+i+"]=");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            for(int i = 0; i < 5; i++)
            {
                matriz[i,1]=(matriz[i,0]+10);
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 2] = (matriz[i, 0] * 2);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            /*2) Solicite ao usuário, preencher uma Matriz 3x3

            // Informe ao usuário:
            //*A soma dos elementos de cada linha

            //-Ex: Linha 1: 30

            //   Linha 2: 17
            //* A soma dos elementos de cada coluna

            // -Ex: Coluna 1: 23

            //    Coluna 2: 36

            int[,] matriz = new int[3, 3];
            int somaLinha1=0, somaLinha2=0,somaLinha3=0,somaColuna1=0,somaColuna2=0,somaColuna3=0;
            Console.WriteLine("Prencha a matriz");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < 3; i++)
            {
                somaLinha1 = matriz[0, i] + somaLinha1;
                somaLinha2 = matriz[1, i] + somaLinha2;
                somaLinha3 = matriz[2, i] + somaLinha3;
                somaColuna1 = matriz[i, 0] + somaColuna1;
                somaColuna2 = matriz[i, 1] + somaColuna2;
                somaColuna3 = matriz[i, 2] + somaColuna3;
            }

            Console.WriteLine("Soma da primeira linha="+somaLinha1+"\nSoma da segunda linha="+somaLinha2+"\nSoma da terceira linha="+somaLinha3+"\nSoma primeira coluna="+somaColuna1+"\nSoma segunda coluna="+somaColuna2+"\nSoma da terceira coluna="+somaColuna3);
            */

            /*3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            int[,] matriz = new int[4, 4];
           
            Console.WriteLine("Prencha a matriz");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Valores diagonal princiapal: " + matriz[i,i]);
            }

            */
            /*4) Popule uma matriz 5x5 e informe:
            // -Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros=0;
            Console.WriteLine("Prencha a matriz");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = i+j;
                    if(matriz[i, j] >= 0)
                    {
                        if(matriz[i, j] != 0) { 
                            positivos++;
                        }
                    }
                    else
                    {
                        negativos++;
                    }
                    if(matriz[i, j] ==0)
                    {
                        zeros++;
                    }
                    else if(matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                    else if(matriz[i, j]%2 != 0)
                    {
                        impares++;
                    }
                    
                }
                
            }
            Console.WriteLine("Quantidade de valores positivos="+positivos+"\nNegativos= "+negativos+"\nZeros= "+zeros+"\nPares= "+pares+"\nImpares= "+impares);
            */

            /*5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.


            int[,] matriz = new int[2, 3], matriz2=new int[2,3], matriz3 = new int[2, 3];
            
            Console.WriteLine("------------------Prencha a matriz 1------------------");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------------Prencha a matriz 2------------------");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }
            Console.WriteLine("------------Mostrando a terceira matriz------------");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz3[i, j] + "  ");
                }
                Console.WriteLine();
            }

            */

            /*6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);
            Random random = new Random();
            int[,] matrix = new int[4, 4];
            int maior = 0;

            for(int i = 0; i < 4; i++)
            {
                for(int j= 0; j < 4; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    if(matrix[i, j] > maior)
                    {
                        maior = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("O maior numero da matriz é:"+maior);
            */

            /*7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            int[,] a = new int[3, 3], b = new int[3, 3], c = new int[3, 3];
            Console.WriteLine("------------------Prencha a matriz 1------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------------Prencha a matriz 2------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = (a[i, j] - b[i, j]);
                }
            }
            Console.WriteLine("------------Mostrando a terceira matriz------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + c[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            /*9) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matrix = new int[4, 4];
            Console.WriteLine("-----------Escreva valores para a matriz-----------");
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------Mostrando a matriz na ordem direta------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------Mostrando a matriz na ordem inversa------------");
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >=0; j--)
                {
                    Console.Write("[" + i + "," + j + "] = " + matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            */

            /*10) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            int[,] matrix = new int[3, 3];
            int num, posL=0, posC=0;
            bool encontrei=false;
            Console.WriteLine("-----------Escreva valores para a matriz-----------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Que numero deseja pesquisar na matriz?");
            num=int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matrix[i, j] == num)
                    {
                        posL= i;
                        posC = j;
                        encontrei=true;
                        break;
                    }
                }
            }

            if (encontrei)
            {
                Console.WriteLine("O numero existe no vetor ["+posL+","+posC+"]");
            }
            else
            {
                Console.WriteLine("Número inexistente");
            }
            */

            /*11) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            int[,] matrix = new int[4, 4], matrix2=new int[4,4];
            int media = 0, abaixo=0,acima=0,naMedia=0;
            Console.WriteLine("------------------Prencha a matriz 1------------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    media = matrix[i, j] + media;
                }
            }
            Console.WriteLine("------------------Prencha a matriz 2------------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                    media = matrix2[i, j] + media;
                }
            }
            media = media / 32;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   if(matrix[i, j]== media)
                    {
                        naMedia++;
                    }
                   else if(matrix[i, j]< media)
                    {
                        abaixo++;
                    }
                   else if (matrix[i, j]> media)
                    {
                        acima++;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix2[i, j] == media)
                    {
                        naMedia++;
                    }
                    else if (matrix2[i, j] < media)
                    {
                        abaixo++;
                    }
                    else if (matrix2[i, j] > media)
                    {
                        acima++;
                    }
                }
            }
            Console.WriteLine("Na media:"+naMedia+"\nAbaixo da média:"+abaixo+"\nAcima da média:"+acima);
            */


            /*12) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
            double[,] A = new double[3, 3], B = new double[3, 3];

            Console.WriteLine("------------Preencha a matriz A------------");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i==0 && j == 0)
                    {
                        B[i, j] = 0;
                    }
                    else { 
                        B[i, j] = A[i, j]/(i+j);
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + B[i, j] + "  ");
                }
                Console.WriteLine();
            }

            */
            /*13) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida
            //mostre na tela apenas os valores cuja soma dos índices (i*j) seja um número par.

            int[,] matriz = new int[4, 3];
            Console.WriteLine("Escreva os valores para a matriz");
            for(int i=0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("["+i+","+j+"]="); 
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------Mostrando os valores cuja soma dos indices é um numero par-----------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0) { 
                        Console.WriteLine("[" + i + "," + j + "]=" + matriz[i,j]);
                    }
                }
               
            }
            */
            /*14) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            //diagonal secundária.
            int[,] matriz = new int[5, 5];
            int somaDPrincipal = 0, somaDSecundaria = 0;
            Console.WriteLine("Escreva os valores para a matriz");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[" + i + "," + j + "]=");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (i == j)
                    {
                        somaDPrincipal = somaDPrincipal + matriz[i, j];
                    }
                    
                }
                Console.WriteLine();
            }

            for (int i = 5 - 1; i >= 0; i--)
            {
                 somaDSecundaria=matriz[i,(5 - 1) - i]+ somaDSecundaria;
            }

            if(somaDPrincipal == somaDSecundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é igual a soma de elementos da diagonal secundaria \n soma diagonal principal:"+somaDPrincipal+"\nsoma diagonal secundaria:"+somaDSecundaria);
            }
            else
            {
                Console.WriteLine("A soma dos dois não é igual,\n soma diagonal principal:" + somaDPrincipal + "\nsoma diagonal secundaria:" + somaDSecundaria);
            }

            */

            /*15) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal
            //(da esquerda para a direita) são os mesmos da diagonal secundária(direita pra esquerda).

            int[,] matriz = new int[5, 5];
            int[] dp = new int[5], ds = new int[5];
            int c = 0;
            Console.WriteLine("Escreva os valores para a matriz");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[" + i + "," + j + "]=");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (i == j)
                    {
                        dp[c] = matriz[i, j];
                        c++;
                    }

                }
                Console.WriteLine();
            }
            c = 0;
            for (int i = 5 - 1; i >= 0; i--)
            {
                ds[c]=matriz[i, (5 - 1) - i] ;
                c++;
            }
            c = 0;
            for(int i=0; i < 5; i++)
            {
                for(int j=0;j<5; j++)
                {
                    if (dp[i] == ds[j])
                    {
                        c++;
                        break;
                    }
                }
            }

            if (c == 5)
            {
                Console.WriteLine("A diagonal secundaria é igual a diagonal principal");
            }
            else
            {
                Console.WriteLine("As diagonais são diferentes");
            }
            */

            /*16) Escreva um programa em C para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
            int[,] a = new int[4, 4], b = new int[4, 4], c = new int[4, 4];
            Console.WriteLine("------------------Prencha a matriz 1------------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------------------Prencha a matriz 2------------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    c[i, j] = (a[i, j] + b[i, j]);
                }
            }
            Console.WriteLine("------------Mostrando a terceira matriz------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + c[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            /*17) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
            int[,] matriz = new int[3, 4], matriz2 = new int[4, 3];
  
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = i + j;
                }
               
            }
            Console.WriteLine("---------------Mostrando a matriz---------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz2[j, i] = matriz[i, j];
                }

            }

            Console.WriteLine("---------------Mostrando a matriz transposta---------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz2[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            /*18) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
            int[,] matriz = new int[10, 10];
            int  linha = 0,maior, minimax=0, coluna=0, menor;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    
                }

            }
            maior = matriz[0, 0];
            
            Console.WriteLine("---------------Mostrando a matriz---------------");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                    if (maior < matriz[i, j])
                    {
                        maior = matriz[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
                Console.WriteLine();
            }
            menor = maior;
            for(int i = 0; i < 10; i++)
            {
                if(matriz[linha, i] < menor)
                {
                    menor= matriz[linha, i];
                    coluna = i;
                }
            }

            Console.WriteLine("O menor elemento da linha onde se encontra o maior elemento da matriz é "+menor+" e se encontra na linha "+ linha+ " e na coluna "+coluna);
            */
        }
    }
}