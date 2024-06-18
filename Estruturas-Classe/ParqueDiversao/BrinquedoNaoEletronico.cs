using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal abstract class BrinquedoNaoEletrico : Brinquedo
    {
        public BrinquedoNaoEletrico()
        {
            this.Nome = "Brinquedo Não Elétrico";
        }

        //public override void abrir()
        //{
        //    base.abrir();
        //}

        //public override void fechar()
        //{
        //    base.fechar();
        //}
    }
}
