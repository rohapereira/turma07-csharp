using System;

//Projeto: Posto
//Um posto esta vendendo combustiveis com a seguinte tabela de descontos:
//Álcool:
//Até 20 litros, desconto de 3% por litro
//acima de 20 litros, desconto de 5% por litro
//Gasolina:
//Até 20 litros, desconto de 4% por litro
//acima de 20 litros, desconto de 6% por litro
//Assim, escreva um programa que leia o numero de litros vendidos , o tipo de combustivel (A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 6,50 e o preço do litro do álcool é R$ 3,90.

namespace Posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Posto--\n");

            const double VALORLITROALCOOL = 3.90;
            const double VALORLITROGASOLINA = 6.50;
            const double VALORDESCONTOLITROALCOOLATE20LITROS = 0.03;
            const double VALORDESCONTOLITROGASOLINAATE20LITROS = 0.04;
            const double VALORDESCONTOLITROALCOOLACIMADE20LITROS = 0.05;
            const double VALORDESCONTOLITROGASOLINAACIMADE20LITROS = 0.06;
            const double LIMITELITROCOMBUSTIVELPARADESCONTO = 20;
            const char ALCOOL = 'A', GASOLINA = 'G';

            Console.WriteLine("Informe o tipo de combustível (A-Álcool G-Gasolina): ");
            char tipoCombustivel = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Informe a quantidade em litros");
            double litros = double.Parse(Console.ReadLine());

            double valorTotal = 0;

            #region "Estrutura de Decisão"
            //if (tipoCombustivel == ALCOOL)
            //{
            //    if (litros <= LIMITELITROCOMBUSTIVELPARADESCONTO)
            //        valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) * litros;
            //    else
            //        valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLACIMADE20LITROS) * litros;
            //}
            //else if (tipoCombustivel == GASOLINA)
            //{
            //    if (litros <= LIMITELITROCOMBUSTIVELPARADESCONTO)
            //        valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) * litros;
            //    else
            //        valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAACIMADE20LITROS) * litros;
            //}
            //else
            //{
            //    Console.WriteLine("Tipo de combustível inválido");
            //}

            //Console.WriteLine($"\nValor a ser pago R${valorTotal}.\n");
            #endregion

            #region "Switch Case"
            //switch (tipoCombustivel)
            //{
            //    case ALCOOL:
            //        if (litros <= LIMITELITROCOMBUSTIVELPARADESCONTO)
            //            valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) * litros;
            //        else
            //            valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLACIMADE20LITROS) * litros;
            //        break;
            //    case GASOLINA:
            //        if (litros <= LIMITELITROCOMBUSTIVELPARADESCONTO)
            //            valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) * litros;
            //        else
            //            valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAACIMADE20LITROS) * litros;
            //        break;
            //    default:
            //        Console.WriteLine("Tipo de combustível inválido");
            //    break;
            //}

            //Console.WriteLine($"\nValor a ser pago R${valorTotal}.\n");
            #endregion

            #region "Operador Ternário => Obter um resultado de forma direta"
            double valorDescontoAlcool = 1 - ((litros <= LIMITELITROCOMBUSTIVELPARADESCONTO) ? VALORDESCONTOLITROALCOOLATE20LITROS : VALORDESCONTOLITROALCOOLACIMADE20LITROS);

            double valorDescontoGasolina = 1 - ((litros <= LIMITELITROCOMBUSTIVELPARADESCONTO) ? VALORDESCONTOLITROGASOLINAATE20LITROS : VALORDESCONTOLITROGASOLINAACIMADE20LITROS);

            double valorLitro = (tipoCombustivel == ALCOOL) ? VALORLITROALCOOL * valorDescontoAlcool : VALORLITROGASOLINA * valorDescontoGasolina; //Alcool ou qualquer coisa diferente de alcool

            double valorTotalAPagar = valorLitro * litros;

            Console.WriteLine($"\nValor a ser pago R${valorTotalAPagar}.\n");
            #endregion

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
