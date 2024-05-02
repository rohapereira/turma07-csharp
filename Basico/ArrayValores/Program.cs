using System;

//Projeto ArrayValores
//Faça um programa que construa um vetor (array) de 8 posições de números inteiros armazenando em sua primeira posição o valor de 10, na segunda posição o dobro do valor da primeira posição (20), na terceira posição o dobro do valor da segunda posição (40), e assim por diante. Ao final, mostre o valor armazenado na oitava posição e a soma de todos os valores armazenados do vetor.

namespace ArrayValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ArrayValores--\n");

            // Construindo o vetor
            int[] vetor = new int[8];

            // Preenchendo o vetor conforme as condições dadas
            vetor[0] = 10;
            for (int i = 1; i < 8; i++)
            {
                vetor[i] = vetor[i - 1] * 2;
            }

            // Calculando a soma dos valores no vetor
            int soma = 0;
            foreach (int valor in vetor)
            {
                soma += valor;
            }

            // Mostrando o valor armazenado na oitava posição e a soma de todos os valores
            Console.WriteLine($"Valor armazenado na oitava posição: {vetor[7]}");
            Console.WriteLine($"Soma de todos os valores armazenados: {soma}");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
