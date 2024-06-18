using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api.Models
{
    public class Paciente
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}