//Exercício 2
//A padaria Hotpão vende uma certa quantidade de pães franceses e uma
//quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
//1,50. Ao final do dia, o dono quer saberquanto arrecadou com a venda dos pães 
//e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
//arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
//nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
//depois calcularos dados solicitados. 

using System;

namespace Exercício2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paoFrances, broa;

            Console.WriteLine("Bem vindo!\n");

            Console.WriteLine("Digite a quantidade de venda dos itens:\n");

            Console.Write("Pães Franceses: ");
            paoFrances = Convert.ToInt32(Console.ReadLine());

            Console.Write("Broas: ");
            broa = Convert.ToInt32(Console.ReadLine());

            double resultadoOperacao, valorDeposito;

            resultadoOperacao = (0.12 * paoFrances) + (1.50 * broa);

            valorDeposito = (resultadoOperacao / 10);

            Console.WriteLine("\nTotal: " + "R$" + resultadoOperacao);

            Console.WriteLine("\nDepósito (10%): " + "R$" + valorDeposito);

            Console.ReadLine();
        }
    }
}
