using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace web_api.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class Paciente
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 100 caracteres.")]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}