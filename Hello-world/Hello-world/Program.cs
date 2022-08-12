using System;

namespace Hello_world
{
    class Program
    {
        // Função Main
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Hello World!\n");

                Console.Write("Largura: ");
                double largura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Resultado: " + CalculaArea(largura, altura) + ".");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }   // Fim try - catch
        }   // Fim Main

        // Função CalculaArea
        static double CalculaArea(double largura, double altura)
        {
            return largura * altura;
        }   // Fim CalculaArea
    }   // Fim Classe Program
}   // Fim Hello_world