using System;

//Crie um programa que verifique se um número é divisível por 2, 3 e 5 ao mesmo tempo.

namespace DivivelPorDoisTresECinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa DivivelPorDoisTresECinco--\n");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0 && numero % 3 == 0 && numero % 5 == 0)
                Console.WriteLine($"O número {numero} é divisível por 2, 3 e 5 ao mesmo tempo.");
            else
                Console.WriteLine($"O número {numero} não é divisível por 2, 3 e 5 ao mesmo tempo.");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
