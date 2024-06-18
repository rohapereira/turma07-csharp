using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exercicio08
{
    public class Cliente
    {
        // Propriedades
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public List<string> Movimentacoes { get; set; }

        // Construtor com parâmetros
        public Cliente(int NumeroConta, decimal Saldo)
        {
            NumeroConta = NumeroConta;
            Saldo = Saldo;
            Movimentacoes = new List<string>();
        }

        // Método AtualizarSaldo
        public void AtualizarSaldo(char operacao, decimal valor)
        {
            if (operacao == 'C')
            {
                Saldo += valor;
                Movimentacoes.Add($"C {valor:C}");
            }
            else if (operacao == 'D')
            {
                Saldo -= valor;
                Movimentacoes.Add($"D {valor:C}");
            }
        }

        // Método MostrarMovimentacoes
        public void MostrarMovimentacoes()
        {
            if (Movimentacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma movimentação realizada.");
            }
            else
            {
                Console.WriteLine("Movimentações:");
                foreach (var mov in Movimentacoes)
                {
                    Console.WriteLine(mov);
                }
            }
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Saldo: {Saldo:C}";
        }
    }
}
