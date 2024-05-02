using System;

/*
Faça um programa para calcular o estoque médio de uma peça, sendo que: 
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
*/

namespace EstoqueMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa EstoqueMedio--\n");

            Console.Write("Informe a quantidade mínima de peças: ");
            int qtdeMinima = int.Parse(Console.ReadLine());

            Console.Write("\nInforme a quantidade máxima de peças: ");
            int qtdeMaxima = int.Parse(Console.ReadLine());

            double estoqueMedio = (qtdeMinima + qtdeMaxima) / 2.0;

            Console.Write($"\nO estoque médio da peça é: {estoqueMedio:0.00}");

            Console.WriteLine("\n\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
