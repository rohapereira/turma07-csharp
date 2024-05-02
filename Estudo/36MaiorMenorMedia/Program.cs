using System;

/*
Faça um programa que leia 10 valores inteiros e positivos e: 
- Encontre o maior valor 
- Encontre o menor valor 
- Calcule a média dos números lidos
*/

namespace _36MaiorMenorMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MaiorMenorMedia--");

            int numero, maior = int.MinValue, menor = int.MaxValue, soma = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"\nDigite o {i}º número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.Write("\nO valor deve ser positivo. Tente novamente.");
                    i--;
                }
                else
                {
                    if (numero > maior)
                        maior = numero;

                    if (numero < menor)
                        menor = numero;

                    soma += numero;
                }
            }

            double media = (double)soma / 10;

            Console.Write($"\nO maior valor digitado foi: {maior}");
            Console.Write($"\nO menor valor digitado foi: {menor}");
            Console.WriteLine($"\nA média dos números digitados é: {media}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
