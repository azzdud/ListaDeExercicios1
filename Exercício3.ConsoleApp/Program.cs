//Exercício 3
//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir 
//quantos dias de vida ela possui. Considere sempre anos completos, e que um 
//ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
//um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.


using System;

namespace Exercício3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ano = 365;

            int idade, resultado;

            string nome = "Neo";

            Console.WriteLine("Contador de dias.");

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nBem vindo(a), " + nome + ". Agora, digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            resultado = ano * idade;

            Console.Write("\nParabéns! Você já sobreviveu ");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(resultado + " dias!\n\n\n\n\n\n");

            Console.WriteLine("Aproveite enquanto há tempo.");

            Console.ReadLine();

        }
    }
}
