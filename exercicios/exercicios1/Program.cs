namespace exercicios1
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

            /*exercicio4

            int dia, mes, ano;

            Console.WriteLine("escreva o dia, mes e ano, nesta ordem");

            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("forma aaaammdd= "+ano+mes+dia);
            Console.WriteLine("forma aammdd= " + (ano/100)+mes+dia);
            */

            //exercicio aula
            /*
            float l1, l2, l3;

            Console.WriteLine("Escreva as medidas de tres lados de um triangulo");
            l1 = float.Parse(Console.ReadLine());
            l2 = float.Parse(Console.ReadLine());
            l3 = float.Parse(Console.ReadLine());

            if(l1==l2 && l2 == l3)
            {
                Console.WriteLine( "o triangulo eh equilatero");
            }
            else if(l1!=l2 && l1!=l3 && l2 !=l3)
            {
                Console.WriteLine("o triângulo eh escaleno");
            }
            else
            {
                Console.WriteLine("o triangulo eh isosceles");
            }
            */

            /*exercicio5
           float distancia,volume;

            Console.WriteLine( "escreva qual a distância e quantos litros gastou para percorre-la, nesta ordem");
            distancia = float.Parse(Console.ReadLine());
            volume = float.Parse(Console.ReadLine());
            Console.WriteLine(distancia/volume+"km/l");
            */

            /*exercicio6
            Console.WriteLine("Informe o código do parafuso A");
            int codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos A");
            int quantA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso A");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código do parafuso B");
            int codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos B");
            int quantB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso B");
            double valorB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o percentual do IPI");
            double ipi = double.Parse(Console.ReadLine());
            double totalA, totalB;
            totalA = (quantA * valorA);
            totalA = totalA + (totalA * (ipi / 100));
            totalB = quantB * valorB;
            totalB = totalB + (totalB * (ipi / 100));
            Console.WriteLine("Custo total dos parafusos A:" + totalA);
            Console.WriteLine("Custo total dos parafusos B:" + totalB);
            */
        

        /*exercicio7
        float numero, salario, taxa, vendas, salario_total;
        Console.WriteLine( "Qual o seu número?");
        numero = float.Parse(Console.ReadLine());
        Console.WriteLine( "Qual o seu salario fixo?");
        salario = float.Parse(Console.ReadLine());
        Console.WriteLine( "Qual a taxa que ganha sobre vendas em porcentagem?");
        taxa = float.Parse(Console.ReadLine());
        Console.WriteLine( "Qual o seu total de vendas?");
        vendas = float.Parse(Console.ReadLine());

        salario_total= salario+((taxa/100)*vendas);
        Console.WriteLine("o seu salario eh de "+salario_total);
        */

        /*exercicio8
        float c,f;
        Console.WriteLine("Digite quala temperatura em celcius?");
        c = float.Parse(Console.ReadLine());
        f=(9*c+160)/5;
        Console.WriteLine("a temperatura em farenheit eh igual a: "+f);
        */

        /*exercicio9

        float valor, entrada , prestacoes;
        Console.WriteLine("escreva qual o valor da sua compra");
        valor = float.Parse(Console.ReadLine());
        if (valor%3!= 0)
        {

        }
        */

        /*exercicio10


        int valor,nota100=0,nota50=0,nota10=0,nota5=0,nota1=0;

        Console.WriteLine( "qual o valor que deseja sacar?");
        valor = int.Parse(Console.ReadLine());
        for (; ; ) { 

            if (valor == 0) {
                break;
            }

            if (valor >= 100){
                nota100++;
                valor=valor-100;
                continue;
            }

            if (valor >= 50)
            {
                nota50++;
                valor=valor-50;
                continue;
            }

            if (valor >= 10)
            {
                nota10++;
                valor=valor-10;
                continue;
            }

            if (valor >= 5)
            {
                nota5++;
                valor=valor-5;
                continue;
            }

            if (valor >= 1)
            {
                nota1++;
                valor=valor-1;
                continue;
            }
        }

        if(nota100 != 0)
        {
            Console.WriteLine(nota100+ " notas de 100");
        }
        if(nota50 != 0)
        {
            Console.WriteLine(nota50+ " notas de 50");
        }
        if(nota10 != 0)
        {
            Console.WriteLine(nota10+ " notas de 10");
        }
        if(nota5 != 0)
        {
            Console.WriteLine(nota5+ " notas de 5");
        }
        if(nota1 != 0)
        {
            Console.WriteLine(nota1+ " notas de 1");
        }
        */


        /*exercicio11

        int vBrancos, vNulos, vValidos, total, pBrancos, pNulos, pValidos;

        Console.WriteLine("escreva qual foi o total de votos");
        total = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva qual foi o total de votos em branco");
        vBrancos = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva qual foi o total de votos nulos");
        vNulos = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva qual foi o total de votos validos");
        vValidos = int.Parse(Console.ReadLine());

        pValidos = (vValidos * 100) / total;
        pBrancos = (vBrancos * 100) / total;
        pNulos = (vNulos * 100) / total;

        Console.WriteLine(pValidos + "% foram validos\n" +pBrancos + "% foram em branco\n" + pNulos +"% foram nulos");

        */

        /*exercicio12

        float combustivel = 6.9, kmi, kmf, kmTotal, litros, valor, valortL;

        Console.WriteLine("quantos litros de combustivel voce gastou?");
        litros = float.Parse(Console.ReadLine());
        Console.WriteLine("quanto o odometro marcava no inicio do dia?");
        kmi = float.Parse(Console.ReadLine());
        Console.WriteLine("quanto o odometro marcava no final do dia?");
        kmf = float.Parse(Console.ReadLine());
        Console.WriteLine("quanto voce recebeu dos passageiros?");
        valor = float.Parse(Console.ReadLine());

        */



    }
    }
}