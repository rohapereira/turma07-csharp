using System;

/*
 Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados. 
*/

namespace _34MenorMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MenorMaior--");

            int numero, menor = int.MaxValue, maior = int.MinValue;

            Console.Write("\nDigite números inteiros positivos ou digite algum número negativo para sair.");

            do
            {
                Console.Write("\nNúmero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero < menor)
                        menor = numero;
                    if (numero > maior)
                        maior = numero;
                }
            } while (numero >= 0);

            if (menor != int.MinValue && maior != int.MinValue)
            {
                Console.Write($"\nO menor número digitado foi: {menor}");
                Console.WriteLine($"\nO maior número digitado foi: {maior}");
            }
            else
                Console.WriteLine("\nNenhum número positivo foi digitado!");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
