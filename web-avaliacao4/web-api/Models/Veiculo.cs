using System;
using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int AnoModelo { get; set; }

        [Required]
        public DateTime DataFabricacao { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [StringLength(500)]
        public string Opcionais { get; set; }
    }
}