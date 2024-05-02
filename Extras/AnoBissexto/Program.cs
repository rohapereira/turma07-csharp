using System;

//Desenvolva um programa que determine se um ano é bissexto ou não.

namespace AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa AnoBissexto--\n");

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
                Console.WriteLine($"\nO ano de {ano} é Bissexto.\n");
            else
                Console.WriteLine($"\nO ano de {ano} não é Bissexto.\n");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
