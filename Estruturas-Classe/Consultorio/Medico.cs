using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    internal class Medico : Interface1
    {
        public string CRM { get; set; }
        public string Nome { get; set; }
        public List<string> Especialidade { get; set; }

        internal Consulta Consulta
        {
            get => default(Consultorio.Consulta);
            set
            {
            }
        }

        public Medico(string crm)
        {
            this.CRM = crm;
            this.Especialidade = new List<string>();
        }
    }
}
