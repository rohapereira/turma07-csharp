using System;

/*
Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.
*/

namespace _51MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MediaAritmetica--");

            Console.Write("\nQuantos alunos deseja cadastrar? ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            double somaDasNotas = 0;
            int contadorNotasAcimaDeSete = 0;
            bool algumAlunoAcimaDeCinco = false;

            Console.WriteLine();
            for (int i = 1; i <= quantidadeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());

                somaDasNotas += nota;

                if (nota > 7.0)
                {
                    contadorNotasAcimaDeSete++;
                }

                if (nota > 5.0)
                {
                    algumAlunoAcimaDeCinco = true;
                }
            }

            double media = somaDasNotas / quantidadeAlunos;

            Console.WriteLine($"\nA média aritmética das notas é: {media}");

            if (algumAlunoAcimaDeCinco)
            {
                Console.WriteLine($"Número de alunos com nota acima de 7.0: {contadorNotasAcimaDeSete}");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.0.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
