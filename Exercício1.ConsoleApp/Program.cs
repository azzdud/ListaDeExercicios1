//Exercício 1
//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um 
//algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.


using System;

namespace ExercíciosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dimensaoX, dimensaoY;

            Console.WriteLine("Leitor de área do terreno\n");

            Console.WriteLine("Digite as dimensões do terreno:\n");

            Console.Write("Digite a altura em metros: ");
            dimensaoX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a base em metros: ");
            dimensaoY = Convert.ToDouble(Console.ReadLine());

            double resultadoOperacao = dimensaoX * dimensaoY;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nÁrea total: " + resultadoOperacao + "m²");

            Console.ReadLine();
        }
    }
}