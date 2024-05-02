using System;

//Faça um programa para imprimir uma tabuada.

namespace _30Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Tabuada--");

            #region "Imprimir a tabuada de um número digitado"
            //Console.Write("\nDigite um número inteiro: ");
            //int numero = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nTabuada do {numero}: ");

            //int i = 0;
            //do
            //{
            //    Console.WriteLine($"{numero} x {i} = {numero * i}");
            //    i++;
            //} while (i < 11);
            #endregion

            #region "Imprimir a tabuada do 0 ao 10"
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"\nTabuada do {i}: ");

                int j = 0;
                do
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    j++;
                } while (j < 11);
            }
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
