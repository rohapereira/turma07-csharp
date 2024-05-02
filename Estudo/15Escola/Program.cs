using System;

/*
Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi 
aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota 
do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7, 
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, 
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do 
aluno.
*/

namespace _15Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Escola--");

            const double MEDIAAPROVACAO = 7;

            Console.Write("\nDigite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= MEDIAAPROVACAO)
            {
                Console.Write($"\nMédia do aluno: {media:0.00}, aluno APROVADO.");
            }
            else
            {
                Console.Write("\nDigite a nota da recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());
                double novaMedia = (media + notaRecuperacao) / 2; 

                if (novaMedia >= MEDIAAPROVACAO)
                {
                    Console.Write($"\nMédia do aluno: {novaMedia:0.00}, aluno APROVADO NA RECUPERAÇÃO.");
                }
                else
                {
                    Console.Write($"\nMédia do aluno: {novaMedia:0.00}, aluno REPROVADO.");
                }
            }

            Console.WriteLine("\n\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
