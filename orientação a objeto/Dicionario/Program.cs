namespace Dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IDictionary<int , string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "Maria");
            dict1.Add(2, "Paulo");
            dict1.Add(3, "Pedro");
            */
            /* Dictionary<int, string> dict1 = new Dictionary<int, string>()
             {
                 { 1, "Maria" },
                 { 2, "Paulo"},
                 { 3, "Pedro"},
             };
             //foreach (KeyValuePair<int, string> item in dict1)
             //{
             //    Console.WriteLine(item.Key + " " + item.Value);
             //}

             string resultado;
             if (dict1.TryGetValue(2, out resultado))
             {
                 Console.WriteLine(resultado);
             }
             else
             {
                 Console.WriteLine("Nao foi possivel encontrar a chave especificada");
             }

             Console.WriteLine(dict1.ContainsKey(1));//retorna true

             Console.WriteLine(dict1.ContainsKey(6));//retorna false


             Console.WriteLine(dict1.ContainsValue("Maria"));
            */

            SortedDictionary<string, int> dict2 = new SortedDictionary<string, int>();

            dict2.Add("Zebra", 5);
            dict2.Add("Cachorro", 2);
            dict2.Add("Gato", 9);
            dict2.Add("Pardal", 4);
            dict2.Add("Ca", 100);

            if (dict2.ContainsKey("Gato"))
            {
                Console.WriteLine("Tem um gato ai...");
            }

            if (dict2.ContainsKey("Zebra"))
            {
                Console.WriteLine("Deu zebra pois nao tem zebra ai....");
            }

            int v;
            if(dict2.TryGetValue("ca", out v))
            {
                Console.WriteLine(v);
            }
            foreach (KeyValuePair<string, int> item in dict2)
            {
                Console.WriteLine(item.Key+ " "+ item.Value);
            }
            Console.ReadKey();
            
               
            

        }
    }
}