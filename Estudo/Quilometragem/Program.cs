using System;

/*
Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 
12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. 
Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. 
Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a 
fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, 
tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*/

namespace Quilometragem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Quilometragem--");

            const double KMPORLITRO = 12.0;

            Console.Write("\nDigite o tempo em horas gasto na viagem: ");
            double tempoGasto = double.Parse(Console.ReadLine());

            Console.Write("\nA média de velociadade em km/h na viagem foi de: ");
            double mediaKmPorHora = double.Parse(Console.ReadLine());

            double distaciaPercorrida = tempoGasto * mediaKmPorHora;
            double litrosUsados = distaciaPercorrida / KMPORLITRO;

            Console.WriteLine("\nResultados da viagem: ");
            Console.Write($"\nA velocidade média foi {mediaKmPorHora}Km/h");
            Console.Write($"\nO tempo de viagem foi de {tempoGasto}h");
            Console.Write($"\nA distância percorrida foi de {distaciaPercorrida}Km");
            Console.WriteLine($"\nA quantidade de litros utilizada na viagem foi de  {litrosUsados:0.00}L");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
