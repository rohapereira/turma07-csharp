using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato_Grupo2
{
    internal class LavaJato
    {
        private Queue<Carro> filaDeEspera;
        private List<Carro> patioEntrega;

        public LavaJato()
        {
            this.filaDeEspera = new Queue<Carro>();
            this.patioEntrega = new List<Carro>();
        }

        public void AdicionarFila(Carro carrosEntrada)
        {
            this.filaDeEspera.Enqueue(carrosEntrada);
        }

        public void RemoverFila()
        {
            this.patioEntrega.Add(filaDeEspera.Dequeue());
        }
        public void GetPatio()
        {
            Console.WriteLine($"Os carros a seguir estão lavados");
            foreach (Carro espera in patioEntrega)
            {
                Console.WriteLine($" \n{espera.Id}, {espera.Nome} {espera.Modelo}");
            }
        }
    }
}
