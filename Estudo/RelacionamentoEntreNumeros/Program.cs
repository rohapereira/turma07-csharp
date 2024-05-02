using System;

/*
Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes 
entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.
*/

namespace RelacionamentoEntreNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa RelacionamentoEntreNumeros--");

            Console.Write("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.Write($"\nOs números {numero1} e {numero2} são iguais.");
            }
            else
            {
                Console.Write($"\nOs números {numero1} e {numero2} não são iguais.");

                if (numero1 > numero2)
                {
                    Console.Write($"\n{numero1} é maior que {numero2}.");
                    Console.Write($"\n{numero2} é menor que {numero1}.");
                }
                else
                {
                    Console.Write($"\n{numero2} é maior que {numero1}.");
                    Console.Write($"\n{numero1} é menor que {numero2}.");
                }
            }

            if (numero1 >= numero2)
            {
                Console.Write($"\n{numero1} é maior ou igual a {numero2}.");
            }
            else
            {
                Console.Write($"\n{numero2} é maior ou igual a {numero1}.");
            }

            if (numero1 <= numero2)
            {
                Console.Write($"\n{numero1} é menor ou igual a {numero2}.");
            }
            else
            {
                Console.Write($"\n{numero2} é menor ou igual a {numero1}.");
            }

            Console.WriteLine("\n\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
