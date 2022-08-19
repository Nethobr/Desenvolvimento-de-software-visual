using System;

namespace Calculo_de_medias
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] media = {10, 15, 15, 20, 20, 20, 25};
            Console.WriteLine("Média: " + calculaMedia(media) + ".");
            Console.WriteLine("Mediana: "+ calculaMediana(media) + ".");
            Console.WriteLine("Moda: "+ calculoModa(media) + ".");
        }   // Fim Main

        static double calculaMedia (double [] media)
        {   
            double total = 0;
            for (int i = 0; i < media.Length; i++)
            {
                total += media[i];
            }   // Fim for
            return total / media.Length;
        }   // Fim Media
        
        static double calculaMediana (double [] media)
        {   
            int meio = media.Length / 2;
            Array.Sort(media);
            if ((media.Length % 2) == 0)
                return (media[meio] + media[meio - 1]) / 2 ;
            else
                return media[meio];
        }   // Fim calculaMediana

        static double calculoModa (double [] media)
        {
            double [] outro = new double [media.Length];

            for (int i = 0; i < media.Length; i++)
            {
                int count = 0;
                double num = media[i];
                for (int j = 0; j < media.Length; j++)
                {
                    if (media[j] == num)
                        count ++;
                }   // Fim for
                outro[i] = count;
            }   // Fir for

            int max = 0;
            for (int i = 0; i < outro.Length; i++)
            {
                if (outro[i] >= max)
                    max = i;
            }   // Fim for

            return media[max];
        }   // Fim calculoModa
    }   // Fim Program
}   // Fim Calculo_de_medias