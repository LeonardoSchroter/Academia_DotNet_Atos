namespace OO_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
           


        }
    }
}