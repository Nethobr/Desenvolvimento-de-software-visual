using System;

namespace Repetidores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o valor para o Fibonacci: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int ultimo = 1, penultimo = 0;

            for (int i = 0; i < valor; i++)
            {
                int proximo = ultimo + penultimo;
                Console.WriteLine(proximo);
                penultimo = ultimo;
                ultimo = proximo;
            }   // Fim for
        }   // Fim Main
    }   // Fim Program
}   // Fim Repetidores