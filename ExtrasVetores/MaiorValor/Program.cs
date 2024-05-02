using System;

//Faça um algoritmo que leia 10 salários. Depois de lidos e armazenados, mostre o maior valor. Utilize vetores.

namespace MaiorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QTDDESALARIOS = 10;
            double[] salarios = new double[QTDDESALARIOS];
            double maior = double.MinValue;

            Console.WriteLine("--Bem vindo ao programa MaiorValor--\n");

            for (int i = 0; i < QTDDESALARIOS; i++)
            {
                Console.Write($"Digite o {i + 1}º salário: ");
                salarios[i] = double.Parse(Console.ReadLine());

                if (salarios[i] > maior)
                    maior = salarios[i];
            }

            Console.Write($"\nO maior salário digitado foi: {maior:0.00}\n");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
