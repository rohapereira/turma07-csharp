using System;

/*
Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do 
menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.
*/

namespace _16MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MaiorMenor--");

            Console.Write("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int maior, menor;

            if (numero1 > numero2)
            {
                maior = numero1;
                menor = numero2;

                Console.WriteLine($"\nMaior: {maior} | Menor: {menor}");
            }
            else if (numero1 < numero2)
            {
                maior = numero2;
                menor = numero1;

                Console.WriteLine($"\nMaior: {maior} | Menor: {menor}");
            }
            else
            {
                Console.WriteLine($"\nOs números digitados ({numero1}, {numero2}) são iguais.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();

        }
    }
}
