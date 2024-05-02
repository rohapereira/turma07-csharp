using System;

/*
Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e os quadros subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e pediu que o serviço fosse executado, sem se dar conta de que seria impossível efetuar o pagamento. Faça um programa para calcular o número de grãos que o monge esperava receber.
*/

namespace _43RainhaMonge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa RainhaMonge--");

            // Definindo o número de quadrados do tabuleiro de xadrez
            int totalQuadrados = 64;

            // Inicializando o número de grãos
            ulong totalGraos = 0; // Usando ulong para suportar números grandes

            // Loop para calcular o número de grãos em cada quadrado e somá-los
            for (int i = 1; i <= totalQuadrados; i++)
            {
                // Calculando o número de grãos no quadrado atual (2^(i-1))
                ulong graosNoQuadrado = (ulong)Math.Pow(2, i - 1);

                // Adicionando o número de grãos no quadrado atual ao total
                totalGraos += graosNoQuadrado;
            }

            // Exibindo o resultado
            Console.WriteLine($"\nO número total de grãos esperado pelo monge é: {totalGraos}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
