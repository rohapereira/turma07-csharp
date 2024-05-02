using System;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício em grupo Projeto escola.
               Faça um programa para ler três notas e o numero de faltas de um aluno e escrever qual a sua situação final: Aprovado, Reprovado por Falta, Reprovado por Média.A média para aprovação é 7,0 e o limite de faltas é de 25% do total de aulas.O número de aulas ministradas no semestre foi de 80.A reprovação por falta sobrepõe a reprovação por média.
            */

            const int AULASMINISTRADAS = 80;
            const double MEDIAAPROVAÇÃO = 7;
            const int LIMITEFALTAS = (int)(AULASMINISTRADAS * 0.25);

            Console.WriteLine("--Bem vindo ao programa Escola--");
            Console.WriteLine();

            Console.Write("Digite o número de faltas do aluno: ");
            int faltas = int.Parse(Console.ReadLine());

            if (faltas > LIMITEFALTAS)
                Console.WriteLine("Reprovado por falta!");
            else
            {
                Console.Write("Digite a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                double nota3 = double.Parse(Console.ReadLine());

                double media = (nota1 + nota2 + nota3) / 3;

                if (media < MEDIAAPROVAÇÃO)
                    Console.WriteLine("Reprovado por média!");
                else
                    Console.WriteLine("Aprovado!");
            }

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
