using System;

//Armazene num vetor de 5 posições o salário de 5 pessoas. Se o salário for menor que 1000 reais, forneça um aumento de 10% e sobrescreva o valor antigo. Ao final, mostre a lista de salários atualizada.

namespace Salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QTDDESALARIOS = 5;
            const int VALORMINIMOPARASALARIO = 1000;
            const double PORCENTAGEMDEAUMENTO = 1.10;
            double[] salarios = new double[QTDDESALARIOS];

            Console.WriteLine("--Bem vindo ao programa Salarios--\n");

            for (int i = 0; i < QTDDESALARIOS; i++)
            {
                Console.Write($"Digite o {i + 1}º salário: R$");
                salarios[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < QTDDESALARIOS; i++)
            {
                if (salarios[i] < VALORMINIMOPARASALARIO)
                    salarios[i] *= PORCENTAGEMDEAUMENTO;
            }

            Console.WriteLine("\nLista de salários atualizada: ");
            for (int i = 0; i < QTDDESALARIOS; i++)
            {
                Console.WriteLine($"R${salarios[i]:0.00}");
            }

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
