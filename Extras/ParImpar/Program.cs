using System;

//Crie um programa que verifique se um número é par ou ímpar.

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ParImpar--\n");

            Console.WriteLine("Digite um número qualquer");
            double numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("\nO número digitado é par.\n");
            else
                Console.WriteLine("\nO número digitado é impar.\n");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
