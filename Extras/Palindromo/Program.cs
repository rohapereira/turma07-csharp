using System;

//Escreva um programa que determine se uma palavra é um palíndromo.

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Palindromo--\n");

            Console.Write("Digite uma palavra ou frase: ");
            string palavra = Console.ReadLine();

            palavra = palavra.Replace(" ", "").ToLower();
            int tamanho = palavra.Length - 1, verificador = 0;

            for (int i = 0; i < palavra.Length; i++, tamanho--)
            {
                if (palavra[i] == palavra[tamanho])
                {
                    verificador++;
                }
            }
            if (verificador == palavra.Length)
            {
                Console.WriteLine("É palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é palíndromo");
            }

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
