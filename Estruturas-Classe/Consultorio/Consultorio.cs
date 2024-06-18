using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    internal class Consultorio
    {
        public int Codigo { get; set; }
        public DateTime DataHora { get; set; }
        public Consultorio(int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
