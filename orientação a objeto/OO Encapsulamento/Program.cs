using System;
using System.Runtime.Intrinsics.X86;
using OO_Encapsulamento;
/*
Carro carro = new Carro();
carro.ligar();

bool status = carro.getLigado();
//carro.ligado = false;

carro.setCor("Azul");
Console.WriteLine(carro.getCor());

carro.Modelo = "Sedan";

string x = carro.placa;


if (status)  //if (carro.getLigado())


{
Console.WriteLine("O carro esta ligado");
}
else
{
Console.WriteLine("O carro está desligado");
}
*/
/*
Console.WriteLine("Digite uma temperatura em Fahrenheit");
Temperatura temp = new Temperatura();
temp.setCelsius(double.Parse(Console.ReadLine()));

Console.WriteLine(temp.getCelsius());
*/
/*
Cliente cliente = new Cliente();
cliente.nome = "Leonardo";
cliente.idade = 22;
Conta c = new Conta(cliente, 1000, "Corrente");
while (true)
{
    Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para consultar saldo e 0 para sair ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Digite o valor do saque");
            c.debitar(double.Parse(Console.ReadLine()));
            break;

        case 2:
            Console.WriteLine("Digite o valor a ser depositado");
            c.creditar(double.Parse(Console.ReadLine()));
            break;

        case 3:
            Console.WriteLine("O saldo é de " + c.getSaldo());
            break;

        default:
            Console.WriteLine("O cliente " + c.cliente.nome + " possui salde de " + c.getSaldo());
            return;

    }




}
*/

/*1 - Crie uma classe Livro que represente os dados básicos de um livro.
//Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

Livro livro;

int numPags;
string autor, titulo;

Console.WriteLine("Escreva qual o titulo do livro");
titulo = Console.ReadLine();

Console.WriteLine("Qual o autor do livro");
autor = Console.ReadLine();

Console.WriteLine("Quantas páginas tem o livro?");
numPags = int.Parse(Console.ReadLine());

livro = new Livro(numPags, titulo, autor);

*/

/*4 - Faça um programa que represente a arvore genealógica da tua familia.
//Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.

Pessoa pessoa = new Pessoa();
Console.WriteLine("Qual o nome completo do seu pai e da sua mãe?");
pessoa.setPai(Console.ReadLine());
pessoa.setMae(Console.ReadLine());

Console.WriteLine("Qual seu nome?");
pessoa.setNome(Console.ReadLine());

Console.WriteLine("Qual sua altura?");
pessoa.setAltura(float.Parse(Console.ReadLine()));

Console.WriteLine("Qual seu peso?");
pessoa.setPeso(float.Parse(Console.ReadLine()));
*/

/*5 - Identifique	 as	 classes	 e	 implemente	 um	 programa	 para	
//a	 seguinte	 especificação:	 "O	supermercado	 vende	 diferentes	
//tipos	 de	 produtos.	 Cada	 produto	 tem	 um	 preço	 e	 uma	
//quantidade	em	estoque.	Um	pedido	de	um	cliente	é	composto	de	itens,	
//onde	cada	item	especifica	o	produto	que	o	cliente	deseja	e	a	respectiva	
//quantidade. Esse	pedido	pode	ser	pago	em	dinheiro,	cheque	ou	cartão."


Produto produto = new Produto();
Itens item;
Cliente cliente = new Cliente();
produto.QtdProduto = 60;
produto.Preco = 5;

Console.WriteLine("Qual o nome do cliente?");
cliente.nome = Console.ReadLine();

Console.WriteLine("Qual o cpf do cliente?");
cliente.cpf = Console.ReadLine();

Console.WriteLine("Que produto esta comprando?");
produto.Nome = Console.ReadLine();
Console.WriteLine("Qual a quantidade que deseja comprar ?");

item = new Itens();
item.Produto = produto;

item.setQuantidade(int.Parse(Console.ReadLine()));

Pedido pedido = new Pedido(item, cliente);

pedido.setValor();

Console.WriteLine("valor = R$"+pedido.getValor());
*/

//6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
//void armazenaPessoa(String nome, int idade, float altura);
//void removePessoa(String nome);
//int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa
//void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda

Pessoa[] pessoa = new Pessoa[10];
Agenda agenda = new Agenda(pessoa);
string nome;
int idade;
float altura;
int qtd=0;
int num;

