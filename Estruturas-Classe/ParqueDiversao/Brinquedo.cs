using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal class Brinquedo
    {
        private static int codigo;

        public int Id { get; }
        public string Nome { get; set; }
        protected int idadeMinima;
        private bool aberto;

        public Brinquedo()
        {
            this.Id = ++codigo;
            this.Nome = "";
            this.idadeMinima = 0;
            this.aberto = false;
        }

        //public abstract void abrir();
        //public abstract void fechar();
        public virtual void abrir()
        {
            this.aberto = true;
        }

        public virtual void fechar()
        {
            this.aberto = false;
        }

        public bool isAberto()
        {
            return this.aberto;
        }
    }
}
