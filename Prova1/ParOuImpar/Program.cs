using System;
using System.Net;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            int pontosJogador = 0;
            int pontosComputador = 0;
            string decisao;

            do
            {
                Console.Write("Você quer par (p) ou ímpar (i)? ");
                string opcaoJogador = Console.ReadLine().ToLower();

                while (opcaoJogador != "p" && opcaoJogador != "i")
                {
                    Console.WriteLine("Entra inválida! Por favor, escolha 'p' para par ou 'i' para ímpar.");
                    Console.Write("Você quer par (p) ou ímpar (i)? ");
                    opcaoJogador = Console.ReadLine().ToLower();
                }

                int numeroJogador;
                do
                {
                    Console.Write("Informe um número inteiro (entre 0 e 100): ");
                    if (int.TryParse(Console.ReadLine(), out numeroJogador))
                    {
                        if (numeroJogador >= 0 && numeroJogador <= 100)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Entrada inválida! Por favor, informe um número inteiro entre 0 e 100.");
                } while (true);

                Random roleta = new Random();
                int numeroComputador = roleta.Next(100);

                Console.WriteLine($"Número do Computador: {numeroComputador}");

                int soma = numeroJogador + numeroComputador;
                Console.WriteLine($"Soma: {soma}");

                bool resultadoPar = soma % 2 == 0;
                bool jogadorVenceu = (opcaoJogador == "p" && resultadoPar) || (opcaoJogador == "i" && !resultadoPar);

                if (jogadorVenceu)
                {
                    Console.WriteLine("Você venceu!");
                    pontosJogador++;
                }
                else
                {
                    Console.WriteLine("Computador venceu!");
                    pontosComputador++;
                }

                Console.WriteLine($"Placar atual: Jogador {pontosJogador} x Computador {pontosComputador}");
                Console.WriteLine("");

                Console.Write("Deseja continuar jogando? (s/n): ");
                decisao = Console.ReadLine().ToLower();

                while (decisao != "s" && decisao != "n")
                {
                    Console.WriteLine("Entra inválida! Por favor, escolha 's' para continuar ou 'n' para parar.");
                    Console.Write("Deseja continuar jogando? (s/n): ");
                    decisao = Console.ReadLine().ToLower();
                }

                Console.Clear();

            } while (decisao == "s");

            Console.WriteLine("\n------Resultado final------\n");
            if (pontosJogador > pontosComputador)
            {
                Console.WriteLine($"Jogador {pontosJogador} x {pontosComputador} Computador (Jogador ganhou)");
            }
            else if (pontosJogador < pontosComputador)
            {
                Console.WriteLine($"Jogador {pontosJogador} x {pontosComputador} Computador (Computador ganhou)");
            }
            else
            {
                Console.WriteLine($"Jogador {pontosJogador} x {pontosComputador} Computador (Empate)");
            }

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
