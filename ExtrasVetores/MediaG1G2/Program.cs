using System;
using System.Collections.Generic;

//Faça um programa que pergunte ao usuário o número de alunos a ser lido. O tamanho dos vetores será o número informado pelo usuário. Armazene em um vetor as notas G1 destes alunos; em outro vetor, armazene as notas G2 destes alunos. Ambas notas, G1 e G2, são informadas pelo usuário. Calcule a média aritmética destes alunos e armazene em um terceiro vetor. Ao final, mostre as 3 notas dos alunos.

namespace MediaG1G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa MediaG1G2--");

            #region "Solução usando o Array"
            //Console.Write("\nDigite o número de alunos: ");
            //int numeroAlunos = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //double[] notasG1 = new double[numeroAlunos];
            //double[] notasG2 = new double[numeroAlunos];
            //double[] medias = new double[numeroAlunos];

            //for (int i = 0; i < numeroAlunos; i++)
            //{
            //    Console.Write($"Digite a nota G1 do {i + 1}º aluno: ");
            //    notasG1[i] = double.Parse(Console.ReadLine());

            //    Console.Write($"Digite a nota G2 do {i + 1}º aluno: ");
            //    notasG2[i] = double.Parse(Console.ReadLine());

            //    medias[i] = (notasG1[i] + notasG2[i]) / 2;
            //}

            //Console.WriteLine("\nNotas dos alunos:");
            //for (int i = 0; i < numeroAlunos; i++)
            //{
            //    Console.WriteLine($"Aluno {i + 1}: G1 = {notasG1[i]}, G2 = {notasG2[i]}, Média = {medias[i]}");
            //}
            #endregion

            #region "Solução usando o List"
            Console.Write("\nDigite o número de alunos: ");
            int numeroAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<double> notasG1 = new List<double>(numeroAlunos);
            List<double> notasG2 = new List<double>(numeroAlunos);
            List<double> medias = new List<double>(numeroAlunos);

            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.Write($"Digite a nota G1 do {i + 1}º aluno: ");
                notasG1.Add(double.Parse(Console.ReadLine()));

                Console.Write($"Digite a nota G2 do {i + 1}º aluno: ");
                notasG2.Add(double.Parse(Console.ReadLine()));

                medias.Add((notasG1[i] + notasG2[i]) / 2);
            }

            Console.WriteLine("\nNotas dos alunos:");
            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.WriteLine($"Aluno {i + 1}: G1 = {notasG1[i]}, G2 = {notasG2[i]}, Média = {medias[i]}");
            }

            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
