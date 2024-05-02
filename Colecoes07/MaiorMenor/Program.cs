using System;
using System.Collections.Generic;

//Projeto: MaiorMenor
//Faça um programa que determine o maior e o menor dentre N números. A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar calculando o maior e o menor até que a entrada seja igual a 0 (ZERO). No entanto, no final desse programa apresente os números lidos, o maior e o menor número. O usuário poderá digitar no máximo até 100 números.

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Solução com Array"
            //const int QTDDENUMEROS = 5; //100
            //int[] numeros = new int[QTDDENUMEROS];
            //int contador = 0;

            //int menor = int.MaxValue;
            //int maior = int.MinValue;

            //Console.WriteLine("--Bem vindo ao programa MaiorMenor--");

            //do
            //{
            //    Console.Write("Digite um número inteiro ou 0 para sair: ");
            //    numeros[contador] = int.Parse(Console.ReadLine());

            //    if (numeros[contador] == 0)
            //        break;

            //    if (numeros[contador] > maior)
            //        maior = numeros[contador];

            //    if (numeros[contador] < menor)
            //        menor = numeros[contador];

            //    contador++;

            //} while (contador < QTDDENUMEROS);

            //if (contador > 0)
            //{
            //    Console.Write($"\nO maior número digitado foi: {maior}\n");
            //    Console.Write($"O menor número digitado foi: {menor}\n");

            //    Console.WriteLine("Números digitados: ");
            //    for (int i = 0; i < contador; i++)
            //    {
            //        Console.Write($"{numeros[i]} - ");
            //    }
            //    Console.WriteLine();
            //}
            //else
            //    Console.WriteLine("Nenhum valor foi informado.");
            #endregion

            #region "Solução com List"

            const int QTDDENUMEROS = 5;
            List<int> numeros = new List<int>(QTDDENUMEROS);
            int contador = 0;

            int menor = int.MaxValue;
            int maior = int.MinValue;

            Console.WriteLine("--Bem vindo ao programa MaiorMenor--");

            do
            {
                Console.Write("Digite um número inteiro ou 0 para sair: ");
                int opcaoDigitada = int.Parse(Console.ReadLine());

                numeros.Add(opcaoDigitada);

                if (opcaoDigitada == 0)
                    break;

                if (numeros[contador] > maior)
                    maior = numeros[contador];

                if (numeros[contador] < menor)
                    menor = numeros[contador];

                contador++;

            } while (contador < QTDDENUMEROS);

            if (contador > 0)
            {
                Console.Write($"\nO maior número digitado foi: {maior}\n");
                Console.Write($"O menor número digitado foi: {menor}\n");

                Console.WriteLine("Números digitados: ");
                for (int i = 0; i < contador; i++)
                {
                    Console.Write($"{numeros[i]} - ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Nenhum valor foi informado.");

            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
