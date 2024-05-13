using System;
using System.Security.Cryptography;

//Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números pares e de múltiplos de 5.

namespace _56LerVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LerVetor--\n");

            #region "Exibe a quantidade de números pares e múltiplos de 5"
            //const int TAMANHOVETOR = 10; //50

            //int[] vetor = new int[TAMANHOVETOR];

            //for (int i = 0; i < TAMANHOVETOR; i++)
            //{
            //    Console.Write($"Digite o valor para a posição {i + 1}: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //int pares = 0;
            //int multiplosDe5 = 0;

            //foreach (int numero in vetor)
            //{
            //    if (numero % 2 == 0)
            //    {
            //        pares++;
            //    }
            //    if (numero % 5 == 0)
            //    {
            //        multiplosDe5++;
            //    }
            //}

            //Console.WriteLine($"\nQuantidade de números pares: {pares}");
            //Console.WriteLine($"Quantidade de múltiplos de 5: {multiplosDe5}");
            #endregion

            #region "Exibe os números pares e os números múltiplos de 5"
            const int TAMANHOVETOR = 10; //50

            int[] vetor = new int[TAMANHOVETOR];

            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int pares = 0;
            int multiplosDe5 = 0;

            Console.WriteLine("\nNúmeros pares:");
            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                    pares++;
                }
            }

            Console.WriteLine("\nNúmeros múltiplos de 5:");
            foreach (int numero in vetor)
            {
                if (numero % 5 == 0)
                {
                    Console.WriteLine(numero);
                    multiplosDe5++;
                }
            }

            Console.WriteLine($"\nQuantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {multiplosDe5}");
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
