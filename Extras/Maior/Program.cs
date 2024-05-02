using System;

//Crie um programa que compare três números e determine qual deles é o maior.

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Maior--\n");

            int quantidadeNumeros = 3;
            int maiorNumero = int.MinValue;

            Console.WriteLine($"Digite {quantidadeNumeros} números inteiros:");

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            Console.WriteLine($"O maior número digitado é: {maiorNumero}");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
