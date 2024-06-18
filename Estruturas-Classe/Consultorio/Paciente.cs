using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    internal class Paciente
    {
        public int Codigo { get; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                return DateTime.Now.Year - this.DataNascimento.Year;
            }
        }

        internal Consulta Consulta
        {
            get => default(Consultorio.Consulta);
            set
            {
            }
        }

        public Paciente(int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
