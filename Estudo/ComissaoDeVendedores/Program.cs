using System;

/*
Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
comissão será de 5% do total da venda e que você tem os seguintes dados: 
- Identificação do vendedor
- Código da peça
- Preço unitário da peça 
- Quantidade vendida
*/

namespace ComissaoDeVendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa ComissaoDeVendedores--\n");

            const double PORCENTAGEMDECOMISSAO = 0.05;

            Console.Write("Digite o nome do vendedor: ");
            string nome = Console.ReadLine();

            Console.Write("\nInforme o código da peça: ");
            string codigoPeca = Console.ReadLine();

            Console.Write("\nInforme o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.Write("\nInforme a quantidade vendida: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorTotal = quantidade * precoUnitario;
            double comissao = valorTotal * PORCENTAGEMDECOMISSAO;

            Console.WriteLine($"\nValor da venda = R${valorTotal:0.00} - Comissão do vendedor = R${comissao:0.00}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
