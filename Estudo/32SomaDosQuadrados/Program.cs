using System;

/*
Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.
*/

namespace _32SomaDosQuadrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa SomaDosQuadrados--");

            Console.Write("\nDigite um número inteiro menor que 10 e maior que zero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10)
            {
                int somaQuadrados = 0;
                int contador = 0;

                Console.WriteLine($"\nOs 20 primeiros números ímpares a partir de {numero} são:");
                while (contador < 20)
                {
                    if (numero % 2 != 0)
                    {
                        Console.WriteLine(numero);
                        somaQuadrados += numero * numero;
                        contador++;
                    }
                    numero++;
                }

                Console.WriteLine($"\nA soma dos quadrados dos 20 primeiros números ímpares é: {somaQuadrados}");
            }
            else
            {
                Console.WriteLine("\nO número informado não está na faixa permitida.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
