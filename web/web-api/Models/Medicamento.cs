using System;
using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class Medicamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de fabricação é obrigatório")]
        public DateTime DataDeFabricacao { get; set; }

        public DateTime? DataDeVencimento { get; set; } // Nullable value type
    }
}