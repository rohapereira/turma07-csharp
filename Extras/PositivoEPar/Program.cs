using System;

//Desenvolva um programa que determine se um número é positivo e par.

namespace PositivoEPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PositivoEPar--\n");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero % 2 == 0)
                Console.WriteLine($"O número {numero} é positivo e par.");
            else
                Console.WriteLine($"O número {numero} não é positivo e par.");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
