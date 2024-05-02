using System;
using System.Collections.Generic;

//Escreva um programa que leia um vetor de 20 posições e mostre-o. Em seguida, troque o primeiro elemento com o último, o segundo com o penúltimo, o terceiro com o antepenúltimo, e assim sucessivamente. Mostre o novo vetor depois da troca.

namespace TrocaPosicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa TrocaPosicao--\n");

            #region "Solução usando Array"
            //const int POSICOESVETOR = 20;

            //int[] numeros = new int[POSICOESVETOR];

            //for (int i = 0; i < POSICOESVETOR; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º número: ");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nNúmeros digitados: ");
            //for (int i = 0; i < POSICOESVETOR; i++)
            //{
            //    Console.Write($"{numeros[i]} - ");
            //}
            //Console.WriteLine();

            ////Trocando posições dos valores no vetor
            //int[] numerosTrocados = new int[POSICOESVETOR];
            //int j = POSICOESVETOR - 1;

            //for (int i = 0; i < POSICOESVETOR; i++)
            //{
            //    numerosTrocados[i] = numeros[j];
            //    j--;
            //}

            //Console.WriteLine("\nNúmeros digitados trocados de posição: ");
            //for (int i = 0; i < POSICOESVETOR; i++)
            //{
            //    Console.Write($"{numerosTrocados[i]} - ");
            //}
            //Console.WriteLine();
            #endregion

            #region "Solução usando List"
            const int POSICOESVETOR = 20;

            List<int> numeros = new List<int>(POSICOESVETOR);

            for (int i = 0; i < POSICOESVETOR; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nNúmeros digitados: ");
            for (int i = 0; i < POSICOESVETOR; i++)
            {
                Console.Write($"{numeros[i]} - ");
            }
            Console.WriteLine();

            //Trocando posições dos valores no vetor
            List<int> numerosTrocados = new List<int>(POSICOESVETOR);
            int tamanho = numeros.Count;

            for (int i = 0; i < POSICOESVETOR; i++)
            {
                numerosTrocados.Add(numeros[tamanho - i - 1]);
            }

            Console.WriteLine("\nNúmeros digitados trocados de posição: ");
            for (int i = 0; i < POSICOESVETOR; i++)
            {
                Console.Write($"{numerosTrocados[i]} - ");
            }
            Console.WriteLine();
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
