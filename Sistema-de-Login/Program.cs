using System;
using System.IO;
using System.Security.Cryptography;

namespace Sistema_de_Login
{
    class Program
    {
        static bool cadastrar(String user, String pass)
        {
            String linha = user + "=" + pass;

            // TODO tudo
            File.AppendAllText("users.txt", linha);

            return ;
        }   // Fim cadastrar


        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo!");
            Console.Write("1 - logar, 2 - cadastrar, 3 - sai.");

            bool logout = false;
            while (!sair)
            {
                int op = 0;

                try {
                    op = int.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }   // Fim try-catch
                
                switch (op)
                {
                    case 1:
                        // TODO logar.
                        break;
                    case 2:
                        Console.Write("Digite o nome do usuário: ");
                        String username = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Digte a senha: ");
                        String pass = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Confirm a senha: ");
                        String confirm = Console.ReadLine();

                        if (pass != confirm)
                            Console.WriteLine("Senhas diferentes!!");
                        else
                            if (cadastrar(username, pass))
                                Console.WriteLine("Cadastro efetuado.");
                            else
                                Console.WriteLine("Não deu!");
                        break;
                    case 3:
                        Console.WriteLine("Tchau!!");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }   // Fim switch   
            }   // Fim while
        }
    }
}