using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios_dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
            //            O programa deverá informar o nome do personagem que possuir o maior poder.

            //Regras que deverão ser seguidas para a implementação do algoritmo:

            //                É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades(características)
            //                um nome e um poder.A classe também deverá possuir um método chamado ExibirDados.Esse método
            //                deverá exibir o nome e o poder do personagem em questão.
            //Ao implementar a classe é obrigatório implementar dois construtores(Sobrecarga), um que não recebe parâmetro algum e outro que
            //irá receber o nome e o poder de um personagem

            Personagem p1;
            Personagem p2;
            Personagem p3;

            int poder;
            string nome;

            Console.WriteLine("Qual o nome do primerio personagem?");
            nome = Console.ReadLine();   
            Console.WriteLine("Qual o nivel de poder do primeiro personagem?");
            poder = int.Parse(Console.ReadLine());
            p1 = new Personagem(nome, poder);

            Console.WriteLine("Qual o nome do segundo personagem?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o nivel de poder do segundo personagem?");
            poder = int.Parse(Console.ReadLine());
            p2 = new Personagem(nome, poder);

            Console.WriteLine("Qual o nome do terceiro personagem?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o nivel de poder do terceiro personagem?");
            poder = int.Parse(Console.ReadLine());
            p3 = new Personagem(nome, poder);

            p1.MostrarDados();
            p2.MostrarDados();
            p3.MostrarDados();

            Console.WriteLine("Personagem com maior nivel de poder:");
            if (p1.Poder > p2.Poder && p1.Poder > p3.Poder)
            {
                Console.Write(p1.Nome);

            }
            else if(p2.Poder > p1.Poder && p2.Poder > p3.Poder)
            {
                Console.Write(p2.Nome);
            }
            else
            {
                Console.Write(p3.Nome);
            }
            */

            /*2) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
            //O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

            List<Animais> bichos = new List<Animais>();
            string nome;
            string tipo;
            int ca = 0, ga = 0, pei = 0;
            Console.WriteLine("Insira os dados dos animais, eles só podem ser do tipo cachorro, peixe ou gato");
            for (int i = 0; i < 5; i++)
            {
               
                do
                {
                    Console.WriteLine("Qual o tipo do animal?");
                    tipo = Console.ReadLine();
                    if (tipo == "Peixe" || tipo == "peixe")
                    {
                        pei++;
                        break;
                    }
                    else if (tipo == "Cachorro" || tipo == "cachorro")
                    {
                        ca++;
                        break;
                    }
                    else if (tipo == "gato" || tipo == "Gato")
                    {
                        ga++;
                        break;
                    }
                } while (true);
                Console.WriteLine("Qual o nome do animal?");
                nome = Console.ReadLine();
                bichos.Add(new Animais(nome, tipo));
            }
            Console.WriteLine("cahorros: " + ca + "\nGatos: " + ga + "\npeixes: " + pei);

            */

            //            3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
            //            uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos(privados) posição x, posição y(do asteroide em
            //            um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
            //            (propriedades getter e setter).Além disso, implementar 3 construtores(sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um
            //terceiro que constrói um asteroide com posição x e posição y.
            //O programa principal(main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
            //asteróides da lista.
            /*
            List<Asteroide> asteroides = new List<Asteroide>();
            void MostrarAsteroides()
            {
                int c = 0;
                Console.WriteLine("Lista de asteróides");
                asteroides.ForEach(delegate (Asteroide item)
                {
                    Console.WriteLine("Asteroide" + c + "=\nPosição x: " + item.GetPosicaoX() + "\nPosição y: " + item.GetPosicaoY() + "\nTamanho: " + item.GetTam() + "\nVelocidade: " + item.GetVelocidade() + "\nEnergia: " + item.GetEnergia());
                    c++;
                    Console.WriteLine();
                    Console.WriteLine();
                });
            }

            int  num, velocidade, energia, posicaoY, posicaoX, tam;
            Asteroide a = new Asteroide();

            do
            {
                Console.WriteLine("1-Criar novo asteróide\n2-Sair");
                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {

                    Console.WriteLine("Qual a posição x do asteroide?");
                    posicaoX = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a posição y do asteroide");
                    posicaoY = int.Parse((string)Console.ReadLine());

                    do
                    {
                        Console.WriteLine("Qual o tamanho do asteroide( 1 a 10)");
                        tam = int.Parse(Console.ReadLine());

                    } while (!a.SetTam(tam));

                    do
                    {
                        Console.WriteLine("Qual a velocidade do asteróide?(1 a 5)");
                        velocidade = int.Parse(Console.ReadLine());
                    }while(!a.SetVelocidade(velocidade));

                    do
                    {
                        Console.WriteLine("Qual a energia do asteroide?(1 a 5)");
                        energia = int.Parse(Console.ReadLine());
                    }while (!a.SetEnergia(energia));

                    asteroides.Add(new Asteroide(posicaoX, posicaoY, tam, velocidade, energia));



                }
                else
                {
                    break;
                }

            } while (true);

            MostrarAsteroides();

            */

            /*            4) Crie uma classe para representar um item de cenário, com os atributos privados de:
            //            *descrição(string), 
            //    *data de criação(date -https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
            //    *altura(float).

            //Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir
            //todos dados de um item de cenário. 
            //Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
            //a classe criada.

            Item item;
            float altura;
            string descricao;
            DateTime data;
            Console.WriteLine("Qual a descricao do item?");
            descricao = Console.ReadLine();

            Console.WriteLine("Qual a altura do item que deseja criar?");
            altura = float.Parse(Console.ReadLine());
            data = DateTime.Now;

            item = new Item(descricao, data, altura);

            item.MostrarItens(item);
            item.TempoDeCriacao(item);





            */

            /*            5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
            //            tem como atributos 'x' e 'y'.Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
            //um método para exibir um objeto(x, y).
            //Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
            //os objetos da lista.

            List<PlanoCartesiano> objetos = new List<PlanoCartesiano>();
            int op, x, y;

            void Mostrarobjetos()
            {
                for (int i = 0; i < objetos.Count; i++)
                {
                    Console.WriteLine("Indice: " + i + " X: " + objetos[i].X + " Y: " + objetos[i].Y);
                }

            }

            Console.WriteLine("Cadastrando objetos num plano cartesiano");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pressione 1 para cadastrar objeto ou qualquer outro número para sair");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Qual a posição X e Y do objeto?");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    objetos.Add(new PlanoCartesiano(x, y));
                    Console.WriteLine("Presione enter para continuar.....");
                    Console.ReadKey();
                }
                else { break; }
            }

            Mostrarobjetos();

          */


            /*            6) Crie uma classe para funcionário.Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário(double), a data de entrada no banco(String), seu RG(String) e um valor booleano que indique se o
            //funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.
            //Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método bonifica que aumenta o salario do funcionário de acordo com o parâmetro passado como argumento. Crie, também, um
            //método demite, que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.
            //Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e consultar todos os funcionários cadastratos.

            //Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho".Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
            //Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário

            List<Funcionario> funcionarios = new List<Funcionario>();
            int op,i;
            string nome;
            string departamento;
            double salario;
            string dataEntrada;
            string rg;
            bool ativo;
            int num;
            double bonus;

             bool LocalizarNome(string nome, List<Funcionario> lista)
            {
                foreach (var funcionario in lista)
                {
                    if (funcionario.Nome == nome) { return true; }
                }

                return false;
            }

             int LocalizarIndice(string nome, List<Funcionario> lista)
            {
                int ind = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Nome == nome)
                    {
                        ind = i;
                    }
                }

                return ind;
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------Menu de gerenciamento de funcionários--------");
                Console.WriteLine("O que deseja fazer?\n1-Cadastrar Funcionario\n2-Bonificar algum funcionário\n3-Exibir lista de funcionários ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("CADASTRANDO FUNCIONÁRIO");
                        Console.WriteLine("Qual o nome do funcionário?");
                        nome = Console.ReadLine();
                        Console.WriteLine("Qual o seu departamento?");
                        departamento = Console.ReadLine();
                        Console.WriteLine("Qual o salário?");
                        salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a sua data de entrada na emprese?[dd/mm/aaaa]");
                        dataEntrada = Console.ReadLine();
                        Console.WriteLine("Qual seu RG?");
                        rg = Console.ReadLine();
                        Console.WriteLine("O funcionario ainda esta ativo na emprese?(1 para sim e 2 para não)");
                        num = int.Parse(Console.ReadLine());
                        if(num == 1)
                        {
                            ativo = true;
                        }
                        else
                        {
                            ativo = false;
                        }
                        Console.WriteLine("Qual a sua função na empresa?(1 para operário e 2 para gerente)");
                        num = int.Parse(Console.ReadLine());
                        if(num == 1)
                        {
                            funcionarios.Add(new Operario(nome,departamento, salario, dataEntrada, rg, ativo));
                            Console.WriteLine("Operario adicionado na lista");
                        }
                        else
                        {
                            funcionarios.Add(new Gerente(nome, departamento, salario, dataEntrada, rg, ativo));
                            Console.WriteLine("Gerente adicionado na lista");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Qual o nome do funcionario que deseja bonificar?");
                        nome = Console.ReadLine();
                        if (LocalizarNome(nome, funcionarios))
                        {
                           i= LocalizarIndice(nome, funcionarios);
                            Console.WriteLine("Escreva o valor do bonus do funcionario");
                            bonus = double.Parse(Console.ReadLine());
                            funcionarios[i].Bonifica(bonus);
                            Console.WriteLine("Novo salario do funcionario = R$" + funcionarios[i].Salario);
                        }
                        else
                        {
                            Console.WriteLine("Funcionario não localizado");
                            
                        }
                        break;

                    case 3:
                        if(funcionarios.Count == 0)
                        {
                            Console.WriteLine("Ainda não há ninguem na lista");
                        }
                        else
                        {
                            foreach(var funcionario in funcionarios)
                            {
                                Console.WriteLine("------------" + "\nNome: " + funcionario.Nome + "\nRG: " + funcionario.RG + "\nDepartamento: " + funcionario.Departamento + "\nData de entrada: " + funcionario.DataEntrada + "\nSalário: R$" + funcionario.Salario) ;
                                funcionario.MostrarAtividade();
                                funcionario.Funcao();
                            };
                            
                        }
                        break;
                   
                        

                        
                }
                    



                Console.ReadKey();
            }
            */
            /*7) Crie um dicionário que faça o armazenamento de Livros.Os dados para serem armazenados
            //serão o nome do livro e a quantidade de páginas.Em um menu inicial, possibilite que
            //o usuário do sistema possa cadastrar, consultar todos livros cadastrados ou pesquisar pelo nome do livro.

            Dictionary<string, Livro> dic = new Dictionary<string, Livro>();
            int op, qtdPaginas;
            string nome;
            Livro aux;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para cadastrar livro, 2 para consultar os livros cadastrados, 3 para pesquisar livro pelo nome, 4 para sair");
                op = int.Parse(Console.ReadLine());
                

                if(op == 1)
                {
                    Console.WriteLine("Qual o nome do livro?");
                    nome = Console.ReadLine();
                    Console.WriteLine("Qual o número de paginas do livro?");
                    qtdPaginas = int.Parse(Console.ReadLine());
                    dic.Add(nome, new Livro(nome, qtdPaginas));
                }
                else if(op == 2)
                {
                    foreach(KeyValuePair<string, Livro> item in dic)
                    {
                        Console.WriteLine("-------------------\nNome: "+ item.Value.Nome+ " Quantidade de paginas:"+ item.Value.QtdPaginas);
                    }
                }
                else if(op == 3)
                {
                    Console.WriteLine("Que livro deseja pesquisar?");
                    nome = Console.ReadLine();
                    if (dic.ContainsKey(nome))
                    {
                        dic.TryGetValue(nome, out aux);
                        Console.WriteLine("Nome: "+aux.Nome+ " Quantidade de páginas: "+aux.QtdPaginas);
                    }
                }
                else { break; }


                Console.ReadLine();
            }

            */


        }
    }
}