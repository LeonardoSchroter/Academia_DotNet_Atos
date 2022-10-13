namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bem vindo ao exemplo dos animais!!");
            Animal a; //aqui eu não sei o que ele vai decidir ser
            Console.WriteLine("Hummm Leão?");

            a = new Leao("Rei leão", "masculino", "leãozão");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();
            
            
            Console.WriteLine("Cusco?");
            a = new Cachorro("Caramelo", "masculino", "SRD");
            a.MostraDados();
            a.EmitirSom();
            a.Caminhar();
            a.Dormir();
            */

            int op;
            Eletronico t = new Televisao();
            while (true)
            {
                Console.WriteLine("Ola, boa tarde\nDeseja ligar o equipamento");
                Console.WriteLine("Digite 1 para ligar\nDigite 2 para desligar\nDigite 3 para verificar se está ligado\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());

                if(op == 1)
                {
                    if (t.ligado)
                    {
                        Console.WriteLine("Já está ligado");
                    }
                    else
                    {
                        t.Ligar();
                    }
                }
                else if(op == 2)
                {
                    if (!t.ligado)
                    {
                        Console.WriteLine("Ja está desligado!");
                    }
                    else
                    {
                        t.Desligar();
                    }
                }
                else if( op == 3)
                {
                    if (t.ligado)
                    {
                        Console.WriteLine("Está ligado");
                    }
                    else
                    {
                        Console.WriteLine("Está desligado");
                    }
                }
                else if(op == 4)
                {
                    break;
                }
            }
        }
    }
}