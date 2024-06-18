using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Uma classe Apartamento é uma classe derivada da classe Habitacao, com area atribuída na instanciação igual a 50 m2

namespace Lista1Exercicio02
{
    public class Apartamento : Habitacao
    {
        // Construtor com parâmetros herdados da classe Habitacao e com valor de area atribuido
        public Apartamento(Porta porta) : base (50, porta)
        {
        }
    }
}
