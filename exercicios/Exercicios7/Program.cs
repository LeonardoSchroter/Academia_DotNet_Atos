using System.Runtime.Intrinsics.X86;

namespace Exercicios_OO_classes_criadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 - Crie uma classe Livro que represente os dados básicos de um livro.Faça a leitura pelo teclado
            //dos atributos e crie um construtor para fazer o instanciamento.
            string autor, titulo;
            int qtdPaginas;
            Console.WriteLine("Escreva quem é o autor do livro");
            autor= Console.ReadLine();

            Console.WriteLine("Escreva qual é o titulo do livro");
            titulo= Console.ReadLine();

            Console.WriteLine("Escreva quantas paginas tem o livro");
            qtdPaginas= int.Parse(Console.ReadLine());

            Livro L1 = new Livro(qtdPaginas, titulo, autor);

            L1.MostrarDados();
            */

            /*2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa.
            //Faça métodos para apresentar os dados.Faça a leitura pelo teclado dos
            //atributos e crie um construtor para fazer o instanciamento.  

            double peso, altura;
            int idd;
            string nome;

            Console.WriteLine("Qual o seu nome");
            nome=Console.ReadLine();

            Console.WriteLine("Qual a sua altura?");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade");
            idd = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            peso = double.Parse(Console.ReadLine());

            Pessoa P1 = new Pessoa(altura, nome, peso, idd);

            P1.MostrarDados();
            */


            //Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro, aluguel e cliente.
            Carro carro;
            Cliente cliente;
            Aluguel aluguel;

            Console.WriteLine("Escreva o nome e idade do cliente");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do cliente?");
            int idd = int.Parse(Console.ReadLine());
            cliente = new Cliente(idd, nome);

            Console.WriteLine("Qual modelo de carro que sera alugado?");
            string modelo = Console.ReadLine();

            Console.WriteLine("Qual sera a placa do carro?");
            string placa = Console.ReadLine();

            carro = new Carro(modelo, placa);

            Console.WriteLine("Qual sera o valor do aluguel deste carro?");
            double aluguel1 = double.Parse(Console.ReadLine());

            aluguel = new Aluguel(cliente, aluguel1, carro);

            aluguel.mostrarDados();




        }
    }
}