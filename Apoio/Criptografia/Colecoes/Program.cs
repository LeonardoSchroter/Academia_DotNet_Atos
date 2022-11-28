using Colecoes;

//List<string> palavras = new List<string>();

//for(int i = 0; i<5; i++)
//{
//    Console.WriteLine("Palavra: ");
//    palavras.Add(Console.ReadLine());
//}

//Console.WriteLine("Digite algo para pesquisar");
//string pesquisa = Console.ReadLine();

//if (!palavras.Contains(pesquisa))
//{
//    palavras.Add("nome2");
//}

//palavras.Sort();


//foreach(var item in palavras)
//{
//    Console.WriteLine(item);
//}


//List<Pessoa> pessoas = new List<Pessoa>();
//string nome;
//string cpf;
//DateOnly dataNasc;
//Pessoa p;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Nome: ");
//    nome = Console.ReadLine();
//    Console.WriteLine("CPF: ");
//    cpf = Console.ReadLine();
//    Console.WriteLine("Data de nascimento: ");
//    dataNasc = DateOnly.Parse(Console.ReadLine());

//    p = new Pessoa(nome, cpf, dataNasc);

//    if (!pessoas.Contains(p))
//    {
//        pessoas.Add(p);
//    }


//}

//pessoas.Sort();

//foreach (var item in pessoas)
//{
//    Console.WriteLine(item);
//}

SortedSet<Pessoa> pessoas = new SortedSet<Pessoa>();
Random gerador = new Random();
int numero;

for (int i = 0; i < 10; i++)
{
    numero = gerador.Next(10);
    if (!pessoas.Add(new Pessoa("Nome" + numero, "" + numero, DateOnly.Parse("12/12/2000")))) ;
    {
        System.Console.WriteLine("Pessoa com matricula ja cadastrado");
    }
}

foreach(var i in pessoas)
{
    Console.WriteLine(i);
}


