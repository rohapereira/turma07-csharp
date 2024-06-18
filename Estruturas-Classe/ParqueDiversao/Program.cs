using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parque parque1 = new Parque();

            for (int i = 0; i < 3; i++)
            {
                parque1.adicionarBrinquedo(new Carrossel());
            }

            for (int i = 0; i < 5; i++)
            {
                parque1.adicionarBrinquedo(new MontanhaRussa());
            }

            TrombaTromba tt1 = new TrombaTromba();
            TrombaTromba tt2 = new TrombaTromba();
            TrombaTromba tt3 = new TrombaTromba();

            PulaPula pp1 = new PulaPula();

            TiroAlvo ta1 = new TiroAlvo();
            TiroAlvo ta2 = new TiroAlvo();


            parque1.adicionarBrinquedo(tt1);
            parque1.adicionarBrinquedo(tt2);
            parque1.adicionarBrinquedo(tt3);

            parque1.adicionarBrinquedo(ta1);
            parque1.adicionarBrinquedo(ta2);

            parque1.adicionarBrinquedo(pp1);

            parque1.abrir();

            tt1.fechar();

            parque1.fecharBrinquedo(3);

            parque1.fechar();

            Parque parque2 = new Parque();

            for (int i = 0; i < 3; i++)
            {
                parque2.adicionarBrinquedo(new Carrossel());
            }

            for (int i = 0; i < 2; i++)
            {
                parque2.adicionarBrinquedo(new MontanhaRussa());
            }

            parque2.abrir();
            parque2.fechar();
        }
    }
}
