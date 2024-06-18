using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente(3);
            p1.Nome = "Naiara";
            p1.DataNascimento = Convert.ToDateTime("1983-05-04");
        }
    }
}
