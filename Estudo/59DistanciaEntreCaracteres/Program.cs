using System;

/*
Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro.
Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9 
*/

namespace _59DistanciaEntreCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa DistanciaEntreCaracteres--");

            Console.Write("\nDigite o primeiro caracter de A a Z em ordem alfabética: ");
            char char1 = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Digite o segundo caracter de A a Z em ordem alfabética: ");
            char char2 = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine();

            if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z')
            {
                if (char1 < char2)
                {
                    int numChars = char2 - char1 - 1;
                    Console.WriteLine($"O número de caracteres entre '{char1}' e '{char2}' é: {numChars}");
                }
                else
                {
                    Console.WriteLine("Os caracteres não estão em ordem alfabética, portando o programa será finalizado!");
                }
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
