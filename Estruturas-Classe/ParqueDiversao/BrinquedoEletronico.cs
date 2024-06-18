using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal abstract class BrinquedoEletrico : Brinquedo
    {
        private bool ligado;

        public BrinquedoEletrico()
        {
            this.Nome = "Brinquedo Elétrico";
            this.ligado = false;
            this.idadeMinima = 6;
        }

        public override void abrir()
        {
            base.abrir();
            this.ligar();
        }

        public override void fechar()
        {
            base.fechar();
            this.desligar();
        }

        private void ligar()
        {
            this.ligado = true;
        }

        private void desligar()
        {
            this.ligado = false;
        }

        private bool isLigado()
        {
            return this.ligado;
        }
    }
}
