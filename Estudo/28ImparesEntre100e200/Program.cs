using System;

//Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.

namespace _28ImparesEntre100e200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ImparesEntre100e200--");

            Console.WriteLine("\nImprima os números ímpares entre 100 e 200:\n");

            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
