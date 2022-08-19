using System;

namespace Calculo_de_medias
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] media = {1, 5, 9, 15, 30};
            Console.WriteLine(calculaMedia(media));
        }   // Fim Main

        static double calculaMedia (double [] media)
        {   
            double total = 0;
            int count = 0;
            for (int i = 0; i < media.Length; i++)
            {
                total += media[i];
                count = i+1;
            }   // Fim for
            return total / count;
        }   // Fim Media
    }   // Fim Program
}   // Fim Calculo_de_medias