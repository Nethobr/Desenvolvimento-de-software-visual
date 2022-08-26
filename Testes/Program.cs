using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Jorge Lamentador";

            String newName = nome.Replace(" ", "_");        
            Console.WriteLine(newName);

            String [] palavras = newName.Split("_");
            foreach (String palavra in palavras)
                Console.WriteLine(palavra);
        }
    }
}