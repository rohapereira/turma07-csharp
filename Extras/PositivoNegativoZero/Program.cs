using System;

//Escreva um programa que determine se um número digitado pelo usuário é positivo, negativo ou zero

namespace PositivoNegativoZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PositivoNegativoZero--\n");

            Console.WriteLine("Digite um número qualquer");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                Console.WriteLine("\nO número digitado é negativo.\n");
            else if (numero > 0)
                Console.WriteLine("\nO número digitado é positivo.\n");
            else
                Console.WriteLine("\nO número digitado é igual a zero.\n");

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
