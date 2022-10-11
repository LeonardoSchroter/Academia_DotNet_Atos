﻿using System;
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
int op;
Agenda a = new Agenda();
string nome;
int idade;
int altura;
Pessoa consulta = null;
while (true)
{
    Console.WriteLine("Digite 1 para cadastrar pessoa\nDigite 2 para buscar as informações \nDigite 3 para apagar a pessoa\nDigite 4 para sair");
    op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        Console.WriteLine("Digite o nome da pessoa: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa: ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura da pessoa: ");
        altura = int.Parse(Console.ReadLine());
        a.armazenaPessoa(nome, idade, altura);
        
        Console.Clear();
        a.imprimeAgenda();
    }
    if (op == 2)
    {
        Console.WriteLine("Digite o nome da pessoa que quer buscar: ");
        nome = Console.ReadLine();
        consulta = a.buscaPessoa(nome);
        if (consulta != null)
        {
            Console.WriteLine("Pessoa encontrada! nome: " + consulta.Nome + " idade " + consulta.Idade+ " Altura: "+consulta.Altura);

        }
        else
        {
            Console.WriteLine("pessoa não encontrado!");
        }
    }
    if (op == 3)
    {
        Console.WriteLine("Digite o nome da pessoa: ");
        nome = Console.ReadLine();
        a.removePessoa(nome);
        Console.Clear();
        a.imprimeAgenda();
    }
    if (op == 4)
    {
        break;
    }
}


//7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio.
//A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do
//elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
//Inicializa: que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio(os elevadores sempre começam no térreo e vazio);
//Entra: para acrescentar uma pessoa no elevador(só deve acrescentar se ainda houver espaço);
//Sai: para remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);

//Sobe : para subir um andar(não deve subir se já estiver no último andar);
//Desce: para descer um andar(não deve descer se já estiver no térreo);
//    Encapsular todos os atributos da classe(criar os métodos set e get).


/*8 - Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle de volume permite:
//-aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
//-aumentar e diminuir o número do canal em uma unidade
//- trocar para um canal indicado;
//-consultar o valor do volume de som e o canal selecionado.

Televisao tv = new Televisao();
ControleRemoto controle = new ControleRemoto();

tv.Controle = controle;
tv.Volume = 20;
tv.Canal = 0;
int num = 0;
while (num != 5)
{

    Console.WriteLine("1-aumentar volume\n2- baixar volume\n3-trocar de canal\n4-Consultar canal e volume\n5-Sair");
    num = int.Parse(Console.ReadLine());

    switch (num)
    {

        case 1:
            tv.Volume = tv.Controle.aumentar_volume(tv.Volume);
            break;

        case 2:
            tv.Volume = tv.Controle.abaixar_volume(tv.Volume);
            break;

        case 3:
            tv.Canal = tv.Controle.trocar_canal();
            break;

        case 4:
            tv.Controle.consultarCanalEVolume(tv.Canal, tv.Volume);
            break;

        default:
            break;
            Console.WriteLine("Aperte qualquer tecla para continuar");



    }
}
    */

