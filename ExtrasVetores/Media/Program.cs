using System;
using System.Collections.Generic;
using System.Linq;

//Faca um programa que leia N valores reais. Armazene estes valores num vetor. Ao final, imprima a média aritmética destes valores. 

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Media--");

            #region "Solução 1"
            List<double> notas = new List<double>();

            Console.WriteLine("Quantas notas serão digitadas?");
            int notasDigitadas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < notasDigitadas; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas.Add(double.Parse(Console.ReadLine()));
            }

            Console.Write($"\nA média das notas é: {notas.Average()}");
            #endregion

            #region "Solução 2"
            //Console.WriteLine("Digite a quantidade de valores a serem inseridos:");
            //int quantidadeValores = int.Parse(Console.ReadLine());

            //List<double> valores = new List<double>();

            //for (int i = 0; i < quantidadeValores; i++)
            //{
            //    Console.WriteLine($"Digite o {(i + 1)}º valor: ");
            //    double valor = double.Parse(Console.ReadLine());
            //    valores.Add(valor);
            //}

            //double soma = 0;
            //foreach (double valor in valores)
            //{
            //    soma += valor;
            //}
            //double media = soma / quantidadeValores;

            //Console.WriteLine($"A média aritmética dos valores é: {media}");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
