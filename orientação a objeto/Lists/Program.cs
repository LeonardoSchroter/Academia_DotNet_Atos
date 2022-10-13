
using Lists;

internal class Program
{
    static List<Pessoas> pessoas;
    static void ListaNaoOrdenada()
    {
        Console.WriteLine("Lista não ordenada");
        pessoas.ForEach(delegate (Pessoas p)
        {
            Console.WriteLine(p.Idade + " " + p.Nome);

        });
    }
    static void ListaOrdenadaPorNome()
    {
        Console.WriteLine("Lista ordenada por nome");
        pessoas.Sort(delegate (Pessoas p1, Pessoas p2)
        {
            return p1.Nome.CompareTo(p2.Nome);
        });
        pessoas.ForEach(delegate (Pessoas p)
        {
            Console.WriteLine(p.Idade + " " + p.Nome);
        });
    }
    static void ListaOrdenadaPorIdade()
    {
        Console.WriteLine("Lista ordenada por idade");
        pessoas.Sort(delegate (Pessoas p1, Pessoas p2)
        {
            return p1.Idade.CompareTo(p2.Idade);
        });
        pessoas.ForEach(delegate (Pessoas p)
        {
            Console.WriteLine(p.Idade + " " + p.Nome);
        });
    }

    static void ListaInserirItemNaPosicao()
    {
        Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na 3");
        pessoas.Insert(1, new Pessoas() { Nome = "Bob Dylan", Idade = 78 });
        pessoas.Insert(1, new Pessoas() { Nome = "Jimmy Page", Idade = 81 });

    }
    static void ListaLocalizaPessoaMaisJovem()
    {
        List<Pessoas> jovem = pessoas.FindAll(delegate (Pessoas p) { return p.Idade < 45; });

        Console.WriteLine("Idade é menor que 45 :");
        jovem.ForEach(delegate (Pessoas p)
        {
            Console.WriteLine(p.Nome + " " + p.Idade);
        });
    }

    private static void Main(string[] args)
    {
        pessoas = new List<Pessoas>();
        pessoas.Add(new Pessoas("Leonardo" , 40));
        pessoas.Add(new Pessoas("Fernanda", 30));
        pessoas.Add(new Pessoas("Marcio", 20));

        foreach (Pessoas p in pessoas)
        {
            Console.WriteLine(p.Nome + " " + p.Idade);

        }
        Console.ReadKey();

        ListaNaoOrdenada();
        Console.ReadKey();
        ListaOrdenadaPorNome();
        Console.ReadKey();
        ListaOrdenadaPorIdade();
        Console.ReadKey();
        ListaInserirItemNaPosicao();
    }
}