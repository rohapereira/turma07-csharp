using System;

/*
Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo 
e maior que zero. Faça um programa para: 
a. ler pelo teclado o vetor; 
b. ler pelo teclado o número X; 
c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.
*/

namespace _47VetorMaiorMenorOuIgualX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa VetorMaiorMenorOuIgualX--");

            #region "Solução que mostra a quantidade de números maiores, menores e iguais a X"
            //const int TAMANHOVETOR = 10;

            //int[] vetor = new int[TAMANHOVETOR];

            //int maiorQueX = 0, menorQueX = 0, igualAX = 0;

            //Console.WriteLine("\nDigite os elementos do vetor de números inteiros maiores que zero:\n");
            //for (int i = 0; i < TAMANHOVETOR; i++)
            //{
            //    Console.Write($"{i + 1}º elemento: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("\nDigite um número inteiro maior que zero para comparação com os elementos do vetor: ");
            //int x = int.Parse(Console.ReadLine());

            //foreach (int num in vetor)
            //{
            //    if (num > x)
            //        maiorQueX++;
            //    else if (num < x)
            //        menorQueX++;
            //    else
            //        igualAX++;
            //}

            //Console.Write($"\nNúmeros maiores que {x}: {maiorQueX}");
            //Console.Write($"\nNúmeros menores que {x}: {menorQueX}");
            //Console.WriteLine($"\nNúmeros iguais a {x}: {igualAX}");
            #endregion

            #region "Solução que mostra quais são os números maiores, menores e iguais a X"
            const int TAMANHOVETOR = 10;

            int[] vetor = new int[TAMANHOVETOR];
            int[] maiorQueX = new int[TAMANHOVETOR];
            int[] menorQueX = new int[TAMANHOVETOR];
            int[] igualAX = new int[TAMANHOVETOR];

            int numeroMaiorQueX = 0, numeroMenorQueX = 0, numeroIgualAX = 0;

            Console.WriteLine("\nDigite os elementos do vetor de números inteiros maiores que zero:\n");
            for (int i = 0; i < TAMANHOVETOR; i++)
            {
                Console.Write($"{i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite um número inteiro maior que zero para comparação com os elementos do vetor: ");
            int x = int.Parse(Console.ReadLine());

            foreach (int num in vetor)
            {
                if (num > x)
                    maiorQueX[numeroMaiorQueX++] = num;
                else if (num < x)
                    menorQueX[numeroMenorQueX++] = num;
                else
                    igualAX[numeroIgualAX++] = num;
            }

            Console.WriteLine($"\nNúmeros maiores que {x}:");
            for (int i = 0; i < numeroMaiorQueX; i++)
            {
                Console.Write($"{maiorQueX[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"\nNúmeros menores que {x}:");
            for (int i = 0; i < numeroMenorQueX; i++)
            {
                Console.Write($"{menorQueX[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"\nNúmeros iguais a {x}:");
            for (int i = 0; i < numeroIgualAX; i++)
            {
                Console.Write($"{igualAX[i]} ");
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
