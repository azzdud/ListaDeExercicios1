//Exercício 4
//Alguns países medem temperaturas em graus Celsius, e outros em graus
//Fahrenheit.Faça um algoritmo para ler uma temperatura Celsius e imprimí-Ia em
//Fahrenheit (pesquise como fazer este tipo de conversão).


using System;

namespace Exercício4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double faren, celsius;

            Console.Write("Conversor de temperatura: \n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("C° para F°\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite os valores em Celsius: C°");            
            celsius = Convert.ToDouble(Console.ReadLine());
            
            faren = celsius * 1.8 + 32;

            Console.WriteLine("\nEsta temperatura em Fahrenheit: " + faren + "F°");

            Console.ReadLine();
        }
    }
}
