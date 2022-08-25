using System;
using System.Text;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Jorge Lamentador";
            
            String newName = nome.Replace(" ", "_");        
            Console.WriteLine(newName);

            String [] palavra = nome.Split(" ");
            Console.WriteLine(palavra[0] + " o " + palavra[1]);


        }
    }
}
