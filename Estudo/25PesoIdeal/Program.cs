using System;

/*
Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, utilizando as seguintes fórmulas: (h = altura) 
- Para homens: (72.7*h) - 58 
- Para mulheres: (62.1 *h) - 44.7 
*/

namespace _25PesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PesoIdeal--");

            Console.Write("\nDigite 'M' se você for homem ou 'F' se for mulher: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double pesoIdeal;
            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"\nO peso ideal para um homem de {altura} metros de altura é {pesoIdeal:0.00}Kg");
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"\nOpeso ideal para uma mulher de {altura} metros de altura é {pesoIdeal:0.00}Kg");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
