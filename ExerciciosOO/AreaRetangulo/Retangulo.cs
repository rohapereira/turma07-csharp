using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
        // Dados privados
        private double baseret;
        private double altret;

        // Métodos de acesso para a base
        public double Base
        {
            get { return baseret; }
            set
            {
                if (value >= 0)
                    baseret = value;
                else
                    baseret = 0;
            }
        }

        // Métodos de acesso para a altura
        public double Altura
        {
            get { return altret; }
            set
            {
                if (value >= 0)
                    altret = value;
                else
                    altret = 0;
            }
        }

        // Métodos para calcular a área
        public double Area
        {
            get { return altret * baseret; }
        }

        // Construtor sem parâmetros
        public Retangulo()
        {
            this.Base = 0;
            this.Altura = 0;
        }

        // Método para exibir dados
        public void ExibeDados()
        {
            Console.WriteLine($"Base: {this.Base:0.00} \nAltura: {this.Altura:0.00} \nArea: {this.Area:0.00}");
        }
    }
}
