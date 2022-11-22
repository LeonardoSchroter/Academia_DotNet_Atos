using Microsoft.EntityFrameworkCore;

namespace AtosEntity_DataBaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n1 para criar uma pessoa\n2 para alterar o nome de uma pessoa" +
                "\n3 para inserir um email\n4 para excluir uma pesosa \n5 para consultar tudo \n6 para consultar´pelo ID");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Inserir o nome da pessoa");
                        Pessoa p = new Pessoa();
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("Informe um email:");
                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Email1 = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa?");
                        int id = int.Parse(Console.ReadLine());


                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.Nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa");
                        int idEmail = int.Parse(Console.ReadLine());
                        Pessoa pEmail = contexto.Pessoas.Find(idEmail);

                        Console.WriteLine("Informe o novo email:");
                        string emailTemp = Console.ReadLine();

                        pEmail.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Email1 = emailTemp
                            }
                        };

                        contexto.Pessoas.Update(pEmail);
                        contexto.SaveChanges();


                    }

                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informar o id da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.Nome);
                        Console.WriteLine("E de seus emails:");

                        foreach (Email iten in p.Emails)
                        {
                            Console.WriteLine("\t" + iten.Email1);
                        }

                        Console.WriteLine("1 para SIM e 3 para NÃO");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.Nome + " excluido com sucesso");
                        }
                        else
                        {
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);


                    }

                    break;
                case 5:

                    try
                    {
                        List<Pessoa> lista = new List<Pessoa>();

                        lista = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.Emails).ToList<Pessoa>();
                        foreach (Pessoa pessoa in lista)
                        {
                            Console.WriteLine(pessoa.Nome);

                            foreach (Email email in pessoa.Emails)
                            {
                                Console.WriteLine("\t" + email.Email1);
                            }
                            Console.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);


                    }

                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails).FirstOrDefault(pesid => pesid.Id == id);

                        Console.WriteLine("Nome: " + p.Nome);

                        if (p.Emails != null)
                        {
                            foreach (Email email in p.Emails)
                            {
                                Console.WriteLine("\t" + email.Email1);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }



                    break;
                default:
                    break;
            }
        }
    }
}