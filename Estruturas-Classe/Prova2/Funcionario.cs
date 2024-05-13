using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Funcionario : Pessoa
    {
        private double salario;

        public Funcionario(string pNome, string uNome, double salario)
                     : base(pNome, uNome)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }
    }

}
