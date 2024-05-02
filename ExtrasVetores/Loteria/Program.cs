using System;
using System.Collections.Generic;

//Escreva um programa que leia um vetor de 13 elementos inteiros, que é o Gabarito de um teste da loteria esportiva, contendo os valores 1 (coluna 1 = vitória do time da casa), 2  (coluna 2 = vitória do time visitante) e 3 (coluna do meio = empate). Leia a seguir para cada apostador, o número do seu cartão e um vetor de Respostas de 13 posições. Verifique para cada apostador os números de acertos, comparando o vetor de Gabarito com o vetor de Respostas. Escreva o número do apostador e o número de acertos. Se o apostador tiver 13 acertos,  mostrar a mensagem "Ganhador".

namespace LoteriaEsportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa LoteriaEsportiva--\n");

            #region "Solução 1 com Array usando função"
            //    // Definindo o tamanho do vetor de gabarito
            //    int tamanhoGabarito = 13;

            //    // Lendo o gabarito
            //    int[] gabarito = new int[tamanhoGabarito];
            //    Console.WriteLine("Digite o gabarito com os valores 1, 2 ou 3 para cada posição:");
            //    for (int i = 0; i < tamanhoGabarito; i++)
            //    {
            //        Console.Write($"Gabarito posição {i + 1}: ");
            //        gabarito[i] = LerNumeroValido();
            //    }

            //    // Lendo o número de apostadores
            //    Console.Write("\nDigite o número de apostadores: ");
            //    int numeroApostadores = LerInteiroPositivo();

            //    // Iterando sobre cada apostador
            //    for (int apostador = 1; apostador <= numeroApostadores; apostador++)
            //    {
            //        // Lendo o número do cartão do apostador
            //        Console.Write($"\nDigite o número do cartão do apostador {apostador}: ");
            //        int numeroCartao = LerInteiroPositivo();

            //        // Lendo as respostas do apostador
            //        int[] respostasApostador = new int[tamanhoGabarito];
            //        Console.WriteLine($"Digite as respostas do apostador {apostador} (valores 1, 2 ou 3):");
            //        for (int i = 0; i < tamanhoGabarito; i++)
            //        {
            //            Console.Write($"Resposta {i + 1}: ");
            //            respostasApostador[i] = LerNumeroValido();
            //        }

            //        // Calculando o número de acertos
            //        int acertos = CalcularAcertos(gabarito, respostasApostador);

            //        // Mostrando o número do apostador e o número de acertos
            //        Console.WriteLine($"O apostador {numeroCartao} acertou {acertos} números.");

            //        // Verificando se o apostador é ganhador
            //        if (acertos == tamanhoGabarito)
            //        {
            //            Console.WriteLine("Ganhador!");
            //        }
            //    }
            //    Console.Write("\n--Digite ENTER para sair--\n");
            //    Console.ReadLine();
            //}

            //// Função para ler um número inteiro válido entre 1 e 3
            //static int LerNumeroValido()
            //{
            //    int numero;
            //    while (!int.TryParse(Console.ReadLine(), out numero) || (numero < 1 || numero > 3))
            //    {
            //        Console.Write("Entrada inválida. Digite novamente: ");
            //    }
            //    return numero;
            //}

            ////Função para ler números inteiros positivos e diferentes de 0
            //static int LerInteiroPositivo()
            //{
            //    int numeroInteiro;
            //    while (!int.TryParse(Console.ReadLine(), out numeroInteiro) || (numeroInteiro <= 0))
            //    {
            //        Console.Write("Entrada inválida. Digite novamente: ");
            //    }
            //    return numeroInteiro;
            //}

            //// Função para calcular o número de acertos entre o gabarito e as respostas do apostador
            //static int CalcularAcertos(int[] gabarito, int[] respostasApostador)
            //{
            //    int acertos = 0;
            //    for (int i = 0; i < gabarito.Length; i++)
            //    {
            //        if (gabarito[i] == respostasApostador[i])
            //        {
            //            acertos++;
            //        }
            //    }
            //    return acertos;
            //}
            #endregion

            #region "Solução 2 com Array sem usar função"
            int[] gabarito = new int[13];

            // Ler gabarito
            Console.WriteLine("Digite o Gabarito (1, 2 ou 3) para cada posição:");
            for (int i = 0; i < gabarito.Length; i++)
            {
                bool inputValido = false;
                while (!inputValido)
                {
                    Console.Write($"Gabarito posição {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out gabarito[i]) && (gabarito[i] >= 1 && gabarito[i] <= 3))
                    {
                        inputValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Digite apenas 1, 2 ou 3.");
                    }
                }
            }

            Console.WriteLine();

            // Quantidade de apostadores
            Console.Write("Digite o número de apostadores: ");
            int quantidadeApostadores = int.Parse(Console.ReadLine());

            // Verificar respostas de cada apostador
            for (int apostador = 1; apostador <= quantidadeApostadores; apostador++)
            {
                Console.Write($"\nDigite o número do cartão do apostador {apostador}: ");
                int cartao = int.Parse(Console.ReadLine());
                int[] respostas = new int[13];
                int acertos = 0;

                // Ler respostas do apostador
                for (int i = 0; i < respostas.Length; i++)
                {
                    bool inputValido = false;
                    while (!inputValido)
                    {
                        Console.Write($"Aposta posição {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out respostas[i]) && (respostas[i] >= 1 && respostas[i] <= 3))
                        {
                            inputValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Digite apenas 1, 2 ou 3.");
                        }
                    }
                }

                // Verificar acertos
                for (int i = 0; i < gabarito.Length; i++)
                {
                    if (gabarito[i] == respostas[i])
                    {
                        acertos++;
                    }
                }

                // Mostrar número do apostador e número de acertos
                Console.WriteLine($"O apostador do cartão número {cartao} acertou {acertos} números.");
                if (acertos == 13)
                {
                    Console.WriteLine("Ganhador");
                }
            }
            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
            #endregion
        }
    }
}