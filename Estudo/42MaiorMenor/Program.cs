using System;

/*
Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO).
*/

namespace _42MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MaiorMenor--");

            int numero, maior = int.MinValue, menor = int.MaxValue;

            Console.WriteLine("\nDigite uma sequência de números ou digite ZERO para sair: ");

            do
            {
                Console.Write("\nDigite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                        maior = numero;

                    if (numero < menor)
                        menor = numero;
                }

            } while (numero != 0);

            if (maior != int.MinValue)
            {
                Console.Write($"\nO maior número digitado é {maior}");
                Console.WriteLine($"\nO menor número digitado é {menor}");
            }
            else
                Console.WriteLine("\nNenhum número válido foi digitado.");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
