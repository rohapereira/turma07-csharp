using System;
using System.Collections.Generic;

// Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima todos os elementos comuns aos dois vetores. 

namespace _54ElementosComunsDosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ElementosComunsDosVetores--");

            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = { 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\nElementos comuns aos dois vetores: ");

            HashSet<int> conjuntoA = new HashSet<int>(A);
            HashSet<int> elementosComuns = new HashSet<int>();

            foreach (int numB in B)
            {
                if (conjuntoA.Contains(numB))
                {
                    elementosComuns.Add(numB);
                }
            }

            foreach (int elemento in elementosComuns)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
