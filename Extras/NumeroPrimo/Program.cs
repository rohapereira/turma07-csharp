using System;

//Crie um programa que determine se um número é primo ou não.

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa NumeroPrimo--\n");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int contador = 1;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    contador++;
            }

            if (contador == 2)
                Console.WriteLine($"O número {numero} é primo");
            else
                Console.WriteLine($"O número {numero} não é primo");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
