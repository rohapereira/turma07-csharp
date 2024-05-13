using System;

/*
Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os tempos registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir: 
    i. melhor tempo; 
    ii. a volta em que o melhor tempo ocorreu; 
    iii. tempo médio das N voltas; 
*/

namespace _53CorridaDeAutomoveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CorridaDeAutomoveis--");

            Console.Write("\nDigite o número de voltas da corrida: ");
            int numeroDeVoltas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            double[] tempos = new double[numeroDeVoltas];

            // Lendo os tempos das voltas
            for (int i = 0; i < numeroDeVoltas; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1} em minutos: ");
                tempos[i] = double.Parse(Console.ReadLine());
            }

            // Encontrando o melhor tempo e a volta correspondente
            double melhorTempo = tempos[0];
            int voltaMelhorTempo = 1;
            for (int i = 1; i < numeroDeVoltas; i++)
            {
                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            // Calculando o tempo médio das voltas
            double tempoTotal = 0;
            for (int i = 0; i < numeroDeVoltas; i++)
            {
                tempoTotal += tempos[i];
            }
            double tempoMedio = tempoTotal / numeroDeVoltas;

            Console.Write($"\nMelhor tempo: {melhorTempo} minutos\n");
            Console.Write($"Volta do melhor tempo: {voltaMelhorTempo}\n");
            Console.WriteLine($"Tempo médio: {tempoMedio} minutos");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
