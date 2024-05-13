using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Personagens
    {
        public string Nome {  get; set; }
        public string Time { get; set; }

        //private List<Arma> armas;

        //private List<Acessorios> acessorios;

        private List<ItemInventario> itens;

        public Personagens() 
        {
            this.itens = new List<ItemInventario>();
            //this.armas = new List<Arma>();
            //this.acessorios = new List<Acessorios>();
        }

        public void adicionarItemInventario(ItemInventario itemInventario)
        {
            this.itens.Add(itemInventario);
        }

        //public void adicionarInentario(Arma arma)
        //{
        //    this.armas.Add(arma);
        //}

        //public void adicionarInventario(Acessorios acessorio)
        //{
        //    this.acessorios.Add(acessorio);
        //}
    }
}
