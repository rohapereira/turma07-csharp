using System;

//Escreva um programa que determine se um ponto está dentro de um círculo com raio especificado.

namespace PontoDentroDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa PontoDentroDoCirculo--\n");

            // Coordenadas do centro do círculo
            double centroX = 0;
            double centroY = 0;

            // Raio do círculo
            double raio = 5;

            // Coordenadas do ponto a ser verificado
            Console.WriteLine("Digite a coordenada X do ponto:");
            double pontoX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a coordenada Y do ponto:");
            double pontoY = Convert.ToDouble(Console.ReadLine());

            // Calcular a distância entre o ponto e o centro do círculo
            double distancia = Math.Sqrt(Math.Pow(pontoX - centroX, 2) + Math.Pow(pontoY - centroY, 2));

            // Verificar se o ponto está dentro do círculo
            if (distancia <= raio)
            {
                Console.WriteLine("O ponto está dentro do círculo.");
            }
            else
            {
                Console.WriteLine("O ponto está fora do círculo.");
            }

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
