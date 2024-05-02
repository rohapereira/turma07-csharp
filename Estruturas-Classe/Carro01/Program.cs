using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro01
{
    struct Carro
    {
        public double potencia;
        public int numeroDePortas;
        public string cor;
        public string nome;
        public int velocidade;

        public Carro(double potencia, int numeroDePortas, string cor, string nome, int velocidade)
        {
            this.potencia = potencia;
            this.numeroDePortas = numeroDePortas;
            this.cor = cor;
            this.nome = nome;
            this.velocidade = velocidade;
        }

        public void Acelerar()
        {
            velocidade++;
        }

        public void Frear()
        {
            velocidade--;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Declaração de variáveis"
            double carro1Potencia = 1.4;
            int carro1NumeroDePortas = 2;
            string carro1Cor = "branca";
            string carro1Nome = "marea";

            double carro2Potencia = 7.5;
            int carro2NumeroDePortas = 2;
            string carro2Cor = "amarela";
            string carro2Nome = "lamborguini";
            #endregion

            #region "Listas"
            List<double> potencias = new List<double>();
            potencias.Add(1.4);
            potencias.Add(7.5);

            List<int> numeroDePortas = new List<int>();
            numeroDePortas.Add(2);
            numeroDePortas.Add(2);

            List<string> cores = new List<string>();
            cores.Add("branca");
            cores.Add("amarela");

            List<string> nomes = new List<string>();
            nomes.Add("marea");
            nomes.Add("lamborguini");
            #endregion

            #region "Estruturas"
            Carro carro1 = new Carro();

            carro1.Acelerar();
            carro1.Acelerar();
            carro1.Acelerar();
            carro1.Acelerar();

            carro1.Frear();

            Carro carro2 = new Carro(7.5, 2, "amarela", "lamborguini", 150);

            Carro carro3;
            carro3 = carro2;
            carro3.nome = "fusca";

            List<Carro> carros = new List<Carro>();

            for (int i = 0; i < 5; i++)
            {
                Carro carro;
                Console.WriteLine("Digite uma potencia");
                carro.potencia = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero de portas");
                carro.numeroDePortas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a cor");
                carro.cor = Console.ReadLine();

                Console.WriteLine("Digite o nome");
                carro.nome = Console.ReadLine();

                Console.WriteLine("Digite a velocidade");
                carro.velocidade = int.Parse(Console.ReadLine());

                carros.Add(carro);
            }
            #endregion
        }
    }
}
