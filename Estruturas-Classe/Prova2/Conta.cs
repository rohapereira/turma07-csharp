using System;
using System.Collections.Generic;

namespace Prova2
{
    internal class Conta
    {
        public DateTime Data { get; }
        public double Valor { get; set; }

        public Conta(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }
    }

    internal class Contas
    {
        private List<Conta> listaDeContas;

        public Contas()
        {
            listaDeContas = new List<Conta>();
        }

        public void adicionar(Conta conta)
        {
            listaDeContas.Add(conta);
        }

        public double getValorTotal()
        {
            double valorTotal = 0;
            foreach (Conta conta in listaDeContas)
            {
                valorTotal += conta.Valor;
            }
            return valorTotal;
        }
    }
}
