using System;
using System.Collections.Generic;

//Escreva uma aplicação no qual o usuário deverá informar 10 números inteiro e maiores que Zero em um vetor. Em um segundo vetor, armazene apenas os números pares e em um terceiro apenas os ímpares. Exiba os 3 vetores, todos em ordem crescente.

namespace ParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ParesImpares--");

            #region "Solução usando Array"
            //const int QTDDENUMEROS = 10;
            //int[] numeros = new int[QTDDENUMEROS];
            //int[] pares = new int[QTDDENUMEROS];
            //int[] impares = new int[QTDDENUMEROS];

            //for (int i = 0; i < QTDDENUMEROS; i++)
            //{
            //    Console.Write("Digite um número inteiro maior que zero: ");
            //    numeros[i] = int.Parse(Console.ReadLine());

            //    if (numeros[i] % 2 == 0)
            //    {
            //        pares[i] = numeros[i];
            //    }
            //    else
            //    {
            //        impares[i] = numeros[i];
            //    }
            //}

            //// ORDENAÇÃO DOS VETORES
            //Array.Sort(numeros);
            //Array.Sort(pares);
            //Array.Sort(impares);

            //Console.WriteLine("\nEstes são os números que você digitou");
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("\nEstes são os pares");
            //foreach (int num in pares)
            //{
            //    if (num != 0)
            //        Console.WriteLine(num);
            //}

            //Console.WriteLine("\nEstes são os ímpares");
            //foreach (int num in impares)
            //{
            //    if (num != 0)
            //        Console.WriteLine(num);
            //}
            #endregion

            #region "Solução usando List"
            const int QTDDENUMEROS = 10;
            List<int> numeros = new List<int>(QTDDENUMEROS);
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < QTDDENUMEROS; i++)
            {
                Console.Write("Digite um número inteiro maior que zero: ");
                int num = int.Parse(Console.ReadLine());
                numeros.Add(num);

                if (num % 2 == 0)
                {
                    pares.Add(num);
                }
                else
                {
                    impares.Add(num);
                }
            }

            // ORDENAÇÃO DAS LISTAS
            numeros.Sort();
            pares.Sort();
            impares.Sort();

            Console.WriteLine("\nEstes são os números que você digitou");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nEstes são os pares");
            foreach (int num in pares)
            {
                if (num != 0)
                    Console.WriteLine(num);
            }

            Console.WriteLine("\nEstes são os ímpares");
            foreach (int num in impares)
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
