//Exercício 5
//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
//Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário
//com o aumento e o salário final. 

using System;

namespace Exercício5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salInicial, salAumento, salFinal;

            String resultado;

            Console.WriteLine("Aumentador de salário 3000\n");

            Console.Write("Digite o salário inicial: ");
            salInicial = Convert.ToDouble(Console.ReadLine());

            salAumento = salInicial * 1.15;

            salFinal = salAumento * 0.92;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nSalário Inicial: " + salInicial);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nSalário Após Aumento (com impostos) " + salAumento);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nSalário Final (descontado impostos) " + salFinal);

            Console.ReadLine();
        }
    }
}
