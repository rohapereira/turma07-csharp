using System;
using System.Collections.Generic;

//Faça um algoritmo que leia e armazene 5 valores inteiros em um vetor Vet1. Leia outros 5 valores inteiros e armazene nem um vetor Vet2. A partir destes valores lidos, mostre na tela:
//a.A soma dos elementos de cada vetor, nas respectivas posições;
//b.A diferença dos elementos de cada vetor, nas respectivas posições;
//c.O produto dos elementos de cada vetor, nas respectivas posições;
//d.A divisão entre os elementos de cada vetor, nas respectivas posições;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Calculadora--\n");

            #region "Solução com Array"
            //const int   QTDNUMEROS = 5;
            //int[] vet1 = new int[QTDNUMEROS];
            //int[] vet2 = new int[QTDNUMEROS];

            //for (int i = 0; i < QTDNUMEROS; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor do vetor 1: ");
            //    vet1[i] = int.Parse(Console.ReadLine());

            //    Console.Write($"Digite o {i + 1}º valor vetor 2: ");
            //    vet2[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nResultados:");
            //for (int i = 0; i < QTDNUMEROS; i++)
            //{
            //    Console.WriteLine($"A soma dos vetores na posição {i + 1} é = {vet1[i] + vet2[i]}");
            //    Console.WriteLine($"A subtração dos vetores na posição {i + 1} é = {vet1[i] - vet2[i]}");
            //    Console.WriteLine($"A multiplicação dos vetores na posição {i + 1} é = {vet1[i] * vet2[i]}");
            //    Console.WriteLine($"A divisão dos vetores na posição {i + 1} é = {vet1[i] / vet2[i]}");
            //}
            #endregion

            #region "Solução com List"
            const int QTDNUMEROS = 5;
            List<int> vet1 = new List<int>(QTDNUMEROS);
            List<int> vet2 = new List<int>(QTDNUMEROS);

            for (int i = 0; i < QTDNUMEROS; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do vetor 1: ");
                vet1.Add(int.Parse(Console.ReadLine()));

                Console.Write($"Digite o {i + 1}º valor vetor 2: ");
                vet2.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nResultados:");
            for (int i = 0; i < QTDNUMEROS; i++)
            {
                Console.WriteLine($"A soma dos vetores na posição {i + 1} é = {vet1[i] + vet2[i]}");
                Console.WriteLine($"A subtração dos vetores na posição {i + 1} é = {vet1[i] - vet2[i]}");
                Console.WriteLine($"A multiplicação dos vetores na posição {i + 1} é = {vet1[i] * vet2[i]}");
                Console.WriteLine($"A divisão dos vetores na posição {i + 1} é = {vet1[i] / vet2[i]}");
            }
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
