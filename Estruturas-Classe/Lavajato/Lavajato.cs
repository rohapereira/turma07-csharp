using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato
{
    internal class Lavajato
    {
        Queue<Carro> filaEspera;
        List<Carro> patioRetirada;

        public Lavajato()
        {
            filaEspera = new Queue<Carro>();
            patioRetirada = new List<Carro>();
        }

        public void addCarroFila(Carro carro)
        {
            filaEspera.Enqueue(carro);
        }

        public void movCarroPatio()
        {
            Console.WriteLine($"Carro {filaEspera.Peek().Id} do cliente {filaEspera.Peek().Nome} lavado e movido para o Pátio de Retirada!");
            patioRetirada.Add(filaEspera.Dequeue());
        }

        public void retiradaCarroPatio(int id)
        {
            bool retirado = false;

            foreach (Carro carro in patioRetirada)
            {
                if (id == carro.Id)
                {
                    Console.WriteLine($"Carro {carro.Id} do cliente {carro.Nome} retirado com sucesso!");
                    retirado = patioRetirada.Remove(carro);
                    break;
                }
            }
            if (!retirado)
            {
                Console.WriteLine("Carro não está pronto!");
            }
        }
    }
}
