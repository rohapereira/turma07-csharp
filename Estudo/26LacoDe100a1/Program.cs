using System;

//Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente. 

namespace _26LacoDe100a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LacoDe100a1--");

            Console.WriteLine("\nImprima os números de 1 a  100 em ordem decrescente:\n");

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
