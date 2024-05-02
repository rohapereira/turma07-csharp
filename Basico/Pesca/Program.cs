using System;

namespace Pesca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Projeto pesca
             Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um programa que leia o peso de peixes e verifique se há excesso. Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar.
              No final, o programa deve imprimir o excesso e a multa paga pelo pescador.
             */

            Console.WriteLine("--Bem vindo ao programa Pesca--");
            Console.WriteLine();

            const double LIMITEEMQUILOS = 50;
            const double MULTA = 4;

            Console.Write("Digite quantos kilos você trouxe em pesca: ");
            double pesoPesca = double.Parse(Console.ReadLine());

            if (pesoPesca <= LIMITEEMQUILOS)
                Console.WriteLine($"O peso de {pesoPesca:0.000}Kg está dentro do permitido para o estado de SP!");
            else
                Console.WriteLine($"Sua pesca excedeu em {pesoPesca - LIMITEEMQUILOS:0.000}Kg o peso total permitido de {LIMITEEMQUILOS}Kg para o estado de SP. O valor da multa a ser paga é de R${(pesoPesca - LIMITEEMQUILOS) * MULTA:0.00}");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
