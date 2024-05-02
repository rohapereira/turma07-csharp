using System;
using System.Collections.Generic;
using System.Security.Cryptography;

//Escrever um programa que lê um vetor K(15) e o escreve. Crie a seguir um vetor P, que contenha todos os números primos de K. Escreva o vetor P.

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa NumerosPrimos--");
            Console.WriteLine();

            #region "Solução usando o Array"
            //const int QTDDENUMEROS = 15;
            //int[] k = new int[QTDDENUMEROS];
            //int[] p = new int[QTDDENUMEROS];
            //int contador = 0; // Contador para o índice de P

            //// Ler o vetor K
            //for (int i = 0; i < QTDDENUMEROS; i++)
            //{
            //    Console.Write($"Digite {QTDDENUMEROS} números inteiros maior que zero: ");
            //    k[i] = int.Parse(Console.ReadLine());
            //}

            //// Identificar números primos e adicionar ao vetor P
            //for (int i = 0; i < QTDDENUMEROS; i++)
            //{
            //    bool ehPrimo = true;

            //    // Verifica se o número é primo
            //    if (k[i] > 1)
            //    {
            //        for (int j = 2; j <= Math.Sqrt(k[i]); j++)
            //        {
            //            if (k[i] % j == 0)
            //            {
            //                ehPrimo = false;
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        ehPrimo = false;
            //    }

            //    // Adiciona o número primo ao vetor P
            //    if (ehPrimo)
            //    {
            //        p[contador] = k[i];
            //        contador++;
            //    }
            //}

            //// ORDENAÇÃO DOS VETORES
            //Array.Sort(k);
            //Array.Sort(p);

            //Console.WriteLine("\nEstes são os números que você digitou");
            //foreach (int num in k)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("\nEstes são os primos");
            //foreach (int num in p)
            //{
            //    if (num != 0)
            //        Console.WriteLine(num);
            //}
            #endregion

            #region "Solução usando o List"
            const int QTDDENUMEROS = 15;
            List<int> k = new List<int>(QTDDENUMEROS);
            List<int> p = new List<int>(QTDDENUMEROS);
            int contador = 0; // Contador para o índice de P

            // Ler o vetor K
            for (int i = 0; i < QTDDENUMEROS; i++)
            {
                Console.Write($"Digite {QTDDENUMEROS} números inteiros maior que zero: ");
                int num = int.Parse(Console.ReadLine());
                k.Add(num);
            }

            // Identificar números primos e adicionar ao vetor P
            for (int i = 0; i < QTDDENUMEROS; i++)
            {
                bool ehPrimo = true;

                // Verifica se o número é primo
                if (k[i] > 1)
                {
                    for (int j = 2; j <= Math.Sqrt(k[i]); j++)
                    {
                        if (k[i] % j == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }
                else
                {
                    ehPrimo = false;
                }

                // Adiciona o número primo ao vetor P
                if (ehPrimo)
                {
                    p.Add(k[i]);
                    contador++;
                }
            }

            // ORDENAÇÃO DOS VETORES
            k.Sort();
            p.Sort();

            Console.WriteLine("\nEstes são os números que você digitou");
            foreach (int num in k)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nEstes são os primos");
            foreach (int num in p)
            {
                if (num != 0)
                    Console.WriteLine(num);
            }
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
