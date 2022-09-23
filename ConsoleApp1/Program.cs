namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*exerxixio1
            int num1, num2;
            Console.WriteLine("escreva dois numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("media aritmetica entre eles: " + (num1 + num2) / 2);
            */

            /*exercicio2
            int num1, num2, num3, num4;
            Console.WriteLine("escreva quatro numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("media aritmetica entre eles: " + (num1 + num2 + num3 + num4) / 4);
            */

            /*exercicio3
            int a = 3, b = 7,aux;

            Console.WriteLine("variavel a= " + a + " variavel b= " + b);
            aux = a;
             a = b;
             b = aux;
            
            Console.WriteLine("variavel a= " + a + " variavel b= " + b);
            */

            int dia, mes, ano;

            Console.WriteLine("escreva o dia, mes e ano, nesta ordem");

            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("forma aaaammdd= "+ano+mes+dia);
            Console.WriteLine("forma aammdd= " + ano+mes+dia);




        }
    }
}