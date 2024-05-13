using System;
using System.Linq;

//Fazer um programa que leia uma frase e imprima somente as vogais.

namespace _57LerFraseImprimirVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LerFraseImprimirVogais--");

            Console.Write("\nDigite uma frase: ");
            string frase = Console.ReadLine();

            // Normalizando a frase para facilitar a verificação de vogais
            frase = frase.ToLower();

            Console.WriteLine("\nVogais na frase:");
            foreach (char c in frase)
            {
                // Verifica se o caractere é uma vogal
                if ("aeiou".Contains(c))
                {
                    Console.Write($"{c} ");
                }
            }

            Console.WriteLine("\n\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
