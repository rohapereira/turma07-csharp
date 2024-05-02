using System;
using System.Runtime.InteropServices;

/*
Escreva um programa que leia: 
- a quantidade de números que deverá processar; 
- os números que deverá processar e calcule e exiba, para cada número a ser processado o seu fatorial. 
Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N
*/

namespace _27Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Fatorial--");

            Console.Write("\nDigite a quantidade de números que deseja processar: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}\n");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        static long CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("Número deve ser não negativo para calcular o fatorial.");
            }

            long fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }
    }
}
