using System;

/*
Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada 
lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é 
eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso 
contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a 
ocorrência.
*/

namespace _19Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Triangulos--");

            Console.Write("\nDigite o valor do primero lado do triângulo: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado do triângulo: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado do triângulo: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > c && b + c > a)
            {
                Console.Write("\nOs trê lados formam um triângulo: ");
                if (a == b && a == c)
                    Console.Write("Equilátero\n");
                else
                    if (a == b || a == c || b == c)
                    Console.Write("Isósceles\n");
                else
                    Console.Write("Escaleno\n");
            }
            else
                Console.Write("\nOs três lados não formam um triângulo!\n");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
