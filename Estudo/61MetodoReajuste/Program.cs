using System;
using System.Linq;

// Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve receber o valor do salário e o índice de reajuste. 

namespace _61MetodoReajuste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MetodoReajuste--");

            Console.Write("\nDigite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o índice de reajuste (em percentagem): ");
            double indiceReajuste = double.Parse(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            Console.WriteLine($"\nO salário atualizado é: R${salarioAtualizado:F2}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        static double Reajuste(double salario, double indiceReajuste)
        {
            // Convertendo o índice de reajuste para proporção (dividindo por 100)
            double proporcaoReajuste = indiceReajuste / 100.0;

            // Calculando o valor do reajuste
            double valorReajuste = salario * proporcaoReajuste;

            // Calculando o salário atualizado
            double salarioAtualizado = salario + valorReajuste;

            return salarioAtualizado;
        }
    }
}
