using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int QUANTIDADETOTALVETOR = 10;

            int x = 1;
            int[] vetor1 = { 1, 2 };
            //string[] fruteira = new striing[QUANTIDADETOTALVETOR];
            string[] fruteira = new string[4];

            //for (int i = 0; i < QUANTIDADETOTALVETOR; i++)
            for (int i = 0; i < fruteira.Length; i++)
            {
                Console.Write($"Digite o nome de {fruteira.Length} frutas: ");
                fruteira[i] = Console.ReadLine();
            }

            foreach (var fruta in fruteira)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine("Digite enter para sair.");
            Console.ReadLine();
        }
    }
}
