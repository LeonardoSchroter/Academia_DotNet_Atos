using System.ComponentModel.DataAnnotations;
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

            /*exercicio6

            string nome;
            float altura, peso,imc;

            Console.WriteLine("digite seu nome ");
            nome= Console.ReadLine();
            nome= nome.ToUpper();

            Console.WriteLine("digite sua altura em metros");
            altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("digite seu peso em kg");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18)
            {
                Console.WriteLine("voce esta abaixo do peso");
            }
            else if (imc <= 25){
                Console.WriteLine("Voce esta no peso normal");
            }
            else if (imc <= 30){
                Console.WriteLine("voce esta com sobrepeso");
            }
            else if (imc <= 35)
            {
                Console.WriteLine("voce possui obesidade");
            }
            else
            {
                Console.WriteLine("obesidade morbida");
            }
            */

            /*exercicio7

            string frase, palavra;
            int c;

            Console.WriteLine("escreva uma frase");
            frase= Console.ReadLine();

            Console.WriteLine("escreva uma palavra para ser buscada na frase");
            palavra= Console.ReadLine();  

            */

            /*exercicio8

            double salarioBase, salarioFinal, tVendas;
            string nome, codigo;

            Console.WriteLine("qual seu codigo e nome?");
            codigo= Console.ReadLine(); 
            nome= Console.ReadLine();

            Console.WriteLine("qual seu salario base e qual foi seu total de vendas?");
            salarioBase = double.Parse(Console.ReadLine());
            tVendas = double.Parse(Console.ReadLine());

            if (tVendas > 5000)
            {
                salarioFinal = tVendas * 0.10 + salarioBase;
            }
            else if (tVendas > 1000)
            {
                salarioFinal = tVendas * 0.07 + salarioBase;
            }
            else if(tVendas>500) { 
                salarioFinal = tVendas * 0.05 + salarioBase;
            }
            else
            {
                salarioFinal = salarioBase;
            }
            Console.WriteLine("este eh seu salario final "+salarioFinal+ "R$");

            */

            /*Exercicio9

            float glicemia1, glicemia2, glicemia3, media;

            Console.WriteLine("digite os seus 3 valores de glicemia em jejum");
            glicemia1=float.Parse(Console.ReadLine());
            glicemia2=float.Parse(Console.ReadLine());
            glicemia3=float.Parse(Console.ReadLine());  

            if (glicemia1 <65 || glicemia2 < 65 || glicemia3 < 65)
            {
                Console.WriteLine("voce corre risco de hipoglicemia");
            }
            else if(glicemia1 > 250 || glicemia2 > 250 || glicemia3 > 250)
            {
                Console.WriteLine("voce corre risco de hiperglicemia");
            }
            media = (glicemia1 + glicemia2 + glicemia3) / 3;

            if (media > 150)
            {
                Console.WriteLine("voce precisa adicionar duas doses de insulina");
            }
            else if(media<80)
            {
                Console.WriteLine("voce deve diminuir duas doses de insulina");
            }
            */

            /*exercicio10

            float idade1, altura1, idade2,altura2;
            string nome1, nome2;

            Console.WriteLine("digite o nome do primeiro atleta");
            nome1 = Console.ReadLine();

            Console.WriteLine("digite a altura dele");
            altura1=float.Parse(Console.ReadLine());

            Console.WriteLine("e qual sua idade");
            idade1= float.Parse(Console.ReadLine());

            Console.WriteLine("digite o nome do segundo atleta");
            nome2 = Console.ReadLine();

            Console.WriteLine("digite a altura dele");
            altura2 = float.Parse(Console.ReadLine());

            Console.WriteLine("e qual sua idade");
            idade2 = float.Parse(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.WriteLine(nome1 + " eh mais novo");
            }
            else if(idade2 < idade1)
            {
                Console.WriteLine(nome2+ " eh mais novo");
            }
            else
            {
                Console.WriteLine("os dois tem a mesma idade");
            }
            if (altura1 > altura2)
            {
                Console.WriteLine(nome1+ " eh mais alto");
            }
            else if(altura2 > altura1)  
            {
                Console.WriteLine(nome2+ " eh mais alto");
            }
            else
            {
                Console.WriteLine("ambos tem a mesma altura");
            }

            */

            /*exercicio11

            int hora, min;

            Console.WriteLine("digite uma hora [hh]");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("digite os minutos [mm]");
            min = int.Parse(Console.ReadLine());

            if(hora<0 || hora > 23)
            {
                Console.WriteLine("a hora nao eh valida");
            }
            else if(min<0 || min > 59)
            {
                Console.WriteLine("a hora digitada nao eh valida");
            }
            else
            {
                Console.WriteLine("a hora eh valida");
            }

            */

            /*exercicio12
             
            int numerohoras, salario, extra;
            string codigo;

            Console.WriteLine("qual seu codigo e quantas horas trabalhou");
            codigo= Console.ReadLine();
            numerohoras= int.Parse(Console.ReadLine());

            if (numerohoras > 50)
            {
                extra=(numerohoras - 50)*20;
                salario = 10 * 50;
            }
            else
            {
                salario = 10 * numerohoras;
                extra = 0;
            }

            Console.WriteLine("Seu salario eh de: "+salario+"R$ \nSeu valor excedente eh de "+ extra +"R$");
            
            */

            /*exercicio13

            double h,peso;
            string sexo;

            Console.WriteLine("qual seu sexo(h para masculino ou f para feminino) e sua altura?");
            sexo = Console.ReadLine();
            h = double.Parse(Console.ReadLine());

            if(sexo== "m")
            {
                peso = (72.7 * h) - 58;
                Console.WriteLine("seu peso ideal eh de "+peso+"kg");
            }
            else if (sexo == "f")
            {
                peso = (62.1 * h) - 44.7;
                Console.WriteLine("seu peso ideal eh de " + peso + "kg");
            }

            */

            //exercicio14

            float tam, link, velocidade;

            Console.WriteLine("qual o tamanho do download que quer realizar?");
            tam = float.Parse(Console.ReadLine());

            Console.WriteLine("qual a velocidade do link que usara?");
            velocidade = float.Parse(Console.ReadLine());
            















        }
    }
}