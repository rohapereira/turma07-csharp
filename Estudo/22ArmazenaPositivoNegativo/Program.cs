using System;

/*
Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o resultado.
*/

namespace _22ArmazenaPositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ArmazenaPositivoNegativo--");

            int a = 0, b = 0;

            Console.Write("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                a = numero;
                Console.WriteLine($"\nNúmero positivo armazenado em A: {a}");
            }
            else if (numero < 0)
            {
                b = numero;
                Console.WriteLine($"\nNúmero negativo armazenado em B: {b}");
            }
            else
            {
                Console.WriteLine("\nZero digitado, portanto não foi armazenado nem em A e nem em B!");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
