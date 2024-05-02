using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Programa: MegaSena
A Mega Sena vai passar por um sorteio e os organizadores do evento pediram a vocês que fizessem o programa que fará esse sorteio. Então faça um programa que armazene num conjunto de dados todas as opções possíveis a serem jogadas em um volante de apostas (são no máximo 60 números por volante). Num outro conjunto armazene os números sorteados de forma aleatória, e leve em consideração que se sortear um número repetido, o programa terá que sortear novamente até que sejam sorteados 6 valores que não se repitam. Ao final do programa, mostre os números sorteados e os números que não foram sorteados.
*/

namespace MegaSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao Programa MegaSena--\n");

            #region "Nossa solução"
            //List<int> lista = new List<int>(60);

            //for (int i = 1; i <= 60; i++)
            //{
            //    lista.Add(i);
            //}

            //List<int> opcoesVolante = new List<int>();
            //Random rand = new Random();

            //while (opcoesVolante.Count < 6)
            //{
            //    int numero = rand.Next(1, 61);

            //    if (!opcoesVolante.Contains(numero))
            //    {
            //        opcoesVolante.Add(numero);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Números sorteados: ");

            //foreach (int numero in opcoesVolante)
            //{
            //    Console.Write($"{numero} ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("\nNúmeros não sorteados: ");

            //foreach (int numero in lista)
            //{
            //    if (!opcoesVolante.Contains(numero))
            //    {
            //        Console.Write($"{numero} "); ;
            //    }
            //}

            //Console.WriteLine();
            #endregion

            #region "Solução do professor"
            Random random = new Random();

            List<int> naoSorteados = new List<int>(60);
            HashSet<int> sorteados = new HashSet<int>(6);

            for (int i = 1; i < 61; i++)
            {
                naoSorteados.Add(i);
            }

            for (int i = 0; i < 6; i++)
            {
                int sorteado = random.Next(1, 61); //primeiro entra no random, segundo não entra no random

                if (!sorteados.Add(sorteado))
                {
                    i--;
                    continue;
                }

                naoSorteados.Remove(sorteado);
            }

            Console.WriteLine("Números sorteados: ");
            foreach (var item in sorteados)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine("\n\nNúmeros não sorteados: ");
            foreach (var item in naoSorteados)
            {
                Console.Write($" {item} ");
            }

            #endregion

            Console.Write("\n\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
