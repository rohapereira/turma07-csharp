using System;

//Desenvolva um programa que determine se um triângulo é equilátero, isósceles ou escaleno com base em seus lados.

namespace Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Triangulos--\n");

            Console.Write("Digite o valor do primero lado do triângulo: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado do triângulo: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado do triângulo: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > c && b + c > a)
            {
                Console.Write("Os trê lados formam um triângulo!\n");
                if (a == b && a == c)
                    Console.Write("Equilátero\n");
                else
                    if (a == b || a == c || b == c)
                        Console.Write("Isósceles\n");
                    else
                        Console.Write("Escaleno\n");
            }
            else
                Console.Write("Os três lados não formam um triângulo!\n");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();

        }
    }
}
