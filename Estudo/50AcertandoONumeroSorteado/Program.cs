using System;

/*
 Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número sorteado é maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas.
*/

namespace _50AcertandoONumeroSorteado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSorteado = random.Next(0, 100);
            int tentativa;
            int tentativasFeitas = 0;

            Console.WriteLine("--Bem vindo ao jogo de advinhação--");
            Console.WriteLine("\nTente advinhar um número entre 0 e 100.\n");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativasFeitas++;

                if (tentativa < numeroSorteado)
                    Console.WriteLine("\nO número sorteado é maior que sua tentativa.\n");
                else if (tentativa > numeroSorteado)
                    Console.WriteLine("\nO número sorteado é menor que a sua tentativa.\n");
                else
                {
                    Console.WriteLine($"\nParabéns, você acertou o número sorteado: {numeroSorteado}");
                    Console.WriteLine($"Quantidade de tentativas: {tentativasFeitas}");
                }
            } while (tentativa != numeroSorteado);

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
