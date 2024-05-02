using System;

/*
Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. Exiba 
ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos que o 
número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o 
fim dos dados.
*/

namespace _31ConjutoNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ConjuntoNumerosPositivos--");

            int numero, somaPares = 0, somaImpares = 0;

            Console.Write("\nDigite números inteiros positivos ou digite algum número negativo para sair: \n");

            do
            {
                Console.Write("\nNúmero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.Write($"O número {numero} é par.\n");
                        somaPares += numero;
                    }
                    else
                    {
                        Console.Write($"O número {numero} é impar.\n");
                        somaImpares += numero;
                    }
                }
            } while (numero >= 0);

            Console.Write($"\nA soma dos números pares é {somaPares}.");
            Console.WriteLine($"\nA soma dos números ímpares é {somaImpares}.");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
