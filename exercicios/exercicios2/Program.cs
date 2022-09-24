using System.Diagnostics.Tracing;

namespace exercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*exercicio1

           int h,b;
            float a;

            Console.WriteLine("Qual o tamanho da base do triangulo?");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tamanho da altura do triangulo?");
            h = int.Parse(Console.ReadLine());

            if (b>0 && h > 0)
            {
                a = (b * h) / 2;
                Console.WriteLine("a area do triangulo eh igual a :" + a);
            }
            else
            {
                Console.WriteLine("Digite valores maiores do que 0 para a base e altura");
            }
            */

            /*exercicio2

            int num;

            Console.WriteLine("escreva um numero");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("o numero digitado eh zero");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("o numero eh par");
            }
            else
            {
                Console.WriteLine("o numero eh impar");
            }
            */

            /*exercicio3

            int num1, num2, num3, num4, media;

            Console.WriteLine("escreva 4 numeros");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            media= (num1 + num2 + num3 + num4)/4;

            if (num1 > media)
            {
                Console.WriteLine(num1 + " eh maior que a media");
            }
            if (num2 > media)
            {
                Console.WriteLine(num2 + " eh maior que a media");
            }
            if (num3 > media)
            {
                Console.WriteLine(num3 + " eh maior que a media");
            }
            if (num4 > media)
            {
                Console.WriteLine(num4 + " eh maior que a media");
            }

            */

            /*exercicio4

            int hora1, hora2, pagamento1, pagamento2, salario1, salario2;

            Console.WriteLine("quanto o primeiro professor recebe por hora e quantas horas ele trabalha?");
            pagamento1 = int.Parse(Console.ReadLine());
            hora1 = int.Parse(Console.ReadLine());

            Console.WriteLine("quanto o segundo professor recebe por hora e quantas horas ele trabalha?");
            pagamento2 = int.Parse(Console.ReadLine());
            hora2 = int.Parse(Console.ReadLine());

            salario1 = pagamento1 * hora1;
            salario2 = pagamento2 * hora2;

            if (salario1 > salario2)
            {
                Console.WriteLine("o primeiro professor possui maior salario");
            }
            else if(salario2 > salario1)
            {
                Console.WriteLine("o segundo professor possui maior salario");
            }
            else
            {
                Console.WriteLine("os dois recebem o mesmo salario");
            }
            */

            /*exercicio5

            int nota1, nota2, media, media2, exame;

            Console.WriteLine("Escreva suas duas notas");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("aprovado");
            }
            else
            {
                Console.WriteLine("Qual foi sua nota no exame?");
                exame= int.Parse(Console.ReadLine());
                media2 = (media + exame) / 2;
                if(media2 >= 5)
                {
                    Console.WriteLine("aprovado");
                }
                else
                {
                    Console.WriteLine("reprovado");
                }
            }

            */

            //exercicio6




        }
    }
}