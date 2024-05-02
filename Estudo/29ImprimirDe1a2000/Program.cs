using System;

//Faça um programa que exiba os números de 1 até 2000.

namespace _29ImprimirDe1a2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ImprimirDe1a2000--");

            Console.WriteLine("\nImprima os números de 1 a 2000:\n");

            for (int i = 1; i < 2001; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();

        }
    }
}
