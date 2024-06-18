using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal class Parque
    {
        public string Nome { get; set; }
        private List<Brinquedo> brinquedos;

        public Parque()
        {
            this.Nome = "";
            this.brinquedos = new List<Brinquedo>();
        }

        public void adicionarBrinquedo(Brinquedo brinquedo)
        {
            this.brinquedos.Add(brinquedo);
        }

        public void abrir()
        {
            foreach (var item in brinquedos)
            {
                item.abrir();
            }
        }

        public void fechar()
        {
            foreach (var item in brinquedos)
            {
                item.fechar();
            }
        }

        public void fecharBrinquedo(int id)
        {
            foreach (var item in brinquedos)
            {
                if (item.Id == id)
                {
                    item.fechar();
                    break;
                }
            }
        }
    }
}
