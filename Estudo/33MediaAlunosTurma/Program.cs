using System;

/*
Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.
*/

namespace _33MediaAlunosTurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MediaAlunosTurma--");

            int numeroMatricula, contador = 0;
            double nota, somaNota = 0.00;

            do
            {
                Console.Write("\nDigite o número da matrícula do aluno ou um número negativo para sair: ");
                numeroMatricula = int.Parse(Console.ReadLine());

                if (numeroMatricula > 0)
                {
                    Console.Write($"Digite a nota do aluno {numeroMatricula}: ");
                    nota = double.Parse(Console.ReadLine());
                    somaNota += nota;
                    contador++;
                }
            } while (numeroMatricula > 0);

            double media = somaNota / contador;

            Console.WriteLine($"\nA média das notas dos alunos é: {media:0.00}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
